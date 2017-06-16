﻿using EncounterGen.Common;
using EncounterGen.Generators;
using Ninject;
using NUnit.Framework;
using RollGen;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EncounterGen.Tests.Integration.Stress
{
    [TestFixture]
    public class EncounterGeneratorTests : StressTests
    {
        [Inject]
        public IEncounterGenerator EncounterGenerator { get; set; }
        [Inject]
        public Random Random { get; set; }
        [Inject]
        public IEncounterVerifier EncounterVerifier { get; set; }
        [Inject]
        public Dice Dice { get; set; }

        private IEnumerable<string> allEnvironments;
        private IEnumerable<string> allTemperatures;
        private IEnumerable<string> allTimesOfDay;
        private IEnumerable<string> allFilters;

        private HashSet<string> usedFilters;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            allEnvironments = new[]
            {
                EnvironmentConstants.Aquatic,
                EnvironmentConstants.Civilized,
                EnvironmentConstants.Desert,
                EnvironmentConstants.Forest,
                EnvironmentConstants.Hills,
                EnvironmentConstants.Marsh,
                EnvironmentConstants.Mountain,
                EnvironmentConstants.Plains,
                EnvironmentConstants.Underground,
            };

            allTemperatures = new[]
            {
                EnvironmentConstants.Temperatures.Cold,
                EnvironmentConstants.Temperatures.Temperate,
                EnvironmentConstants.Temperatures.Warm,
            };

            allTimesOfDay = new[]
            {
                EnvironmentConstants.TimesOfDay.Day,
                EnvironmentConstants.TimesOfDay.Night,
            };

            allFilters = new[]
            {
                CreatureConstants.Types.Aberration,
                CreatureConstants.Types.Animal,
                CreatureConstants.Types.Construct,
                CreatureConstants.Types.Dragon,
                CreatureConstants.Types.Elemental,
                CreatureConstants.Types.Fey,
                CreatureConstants.Types.Giant,
                CreatureConstants.Types.Humanoid,
                CreatureConstants.Types.MagicalBeast,
                CreatureConstants.Types.MonstrousHumanoid,
                CreatureConstants.Types.Ooze,
                CreatureConstants.Types.Outsider,
                CreatureConstants.Types.Plant,
                CreatureConstants.Types.Undead,
                CreatureConstants.Types.Vermin,
            };
        }

        [SetUp]
        public void Setup()
        {
            usedFilters = new HashSet<string>();
        }

        [Test]
        public void StressEncounterGenerator()
        {
            Stress(() => AssertEncounterInRandomEnvironment());
        }

        [Test]
        public void StressEncounterGeneratorWithFilter()
        {
            Stress(() => AssertEncounterInRandomEnvironment(useFilter: true));

            Console.WriteLine($"Stressed the following filters: {string.Join(", ", usedFilters.OrderBy(f => f))}");
            Assert.That(usedFilters.Count, Is.GreaterThan(1));

            var untestedFilters = allFilters.Except(usedFilters);
            Console.WriteLine($"Did not stress the following filters: {string.Join(", ", untestedFilters.OrderBy(f => f))}");
            Assert.That(untestedFilters.Count, Is.LessThan(allFilters.Count()));
        }

        private void AssertEncounterInRandomEnvironment(string environment = "", string temperature = "", string timeOfDay = "", int level = 0, string filter = "", bool useFilter = false)
        {
            var encounter = MakeEncounterInRandomEnvironment(level, environment, temperature, timeOfDay, filter, useFilter);
            AssertEncounter(encounter);
        }

        private Encounter MakeEncounterInRandomEnvironment(int level = 0, string environment = "", string temperature = "", string timeOfDay = "", string filter = "", bool useFilter = false)
        {
            var specifications = Generate(
                () => RandomizeSpecifications(level, environment, temperature, timeOfDay, filter, useFilter),
                s => EncounterVerifier.ValidEncounterExistsAtLevel(s));

            if (specifications.CreatureTypeFilters.Any())
                usedFilters.Add(specifications.CreatureTypeFilters.Single());

            return EncounterGenerator.Generate(specifications);
        }

        private EncounterSpecifications RandomizeSpecifications(int level = 0, string environment = "", string temperature = "", string timeOfDay = "", string filter = "", bool useFilter = false)
        {
            var specifications = new EncounterSpecifications();
            specifications.Environment = string.IsNullOrEmpty(environment) ? GetRandomFrom(allEnvironments) : environment;
            specifications.Temperature = string.IsNullOrEmpty(temperature) ? GetRandomFrom(allTemperatures) : temperature;
            specifications.TimeOfDay = string.IsNullOrEmpty(timeOfDay) ? GetRandomFrom(allTimesOfDay) : timeOfDay;
            specifications.Level = level > 0 ? level : Random.Next(EncounterSpecifications.MaximumLevel) + EncounterSpecifications.MinimumLevel;
            specifications.AllowAquatic = Convert.ToBoolean(Random.Next(2));
            specifications.AllowUnderground = Convert.ToBoolean(Random.Next(2));

            if (!string.IsNullOrEmpty(filter))
            {
                specifications.CreatureTypeFilters = new[] { filter };
            }
            else if (useFilter)
            {
                var randomFilter = GetRandomFrom(allFilters);
                specifications.CreatureTypeFilters = new[] { randomFilter };
            }

            return specifications;
        }

        private string GetRandomFrom(IEnumerable<string> collection)
        {
            var total = collection.Count();
            var randomIndex = Random.Next(total);
            var randomValue = collection.ElementAt(randomIndex);

            return randomValue;
        }

        private void AssertEncounter(Encounter encounter)
        {
            Assert.That(encounter.Creatures, Is.Not.Empty);
            Assert.That(encounter.Creatures, Is.All.Not.Null);
            Assert.That(encounter.Characters, Is.Not.Null);
            Assert.That(encounter.Characters, Is.All.Not.Null);

            foreach (var creature in encounter.Creatures)
            {
                AssertCreatureType(creature.Type);
                Assert.That(creature.Quantity, Is.Positive);
                Assert.That(creature.ChallengeRating, Is.Not.Empty);
            }

            Assert.That(encounter.Treasures, Is.Not.Null);
            Assert.That(encounter.Treasures, Is.All.Not.Null);
            Assert.That(encounter.Treasures.Select(t => t.IsAny), Is.All.True);

            var totalCreatures = encounter.Creatures.Sum(c => c.Quantity);
            Assert.That(encounter.Characters.Count, Is.LessThanOrEqualTo(totalCreatures));
            Assert.That(encounter.Treasures.Count, Is.LessThanOrEqualTo(encounter.Creatures.Count()));

            Assert.That(encounter.TargetEncounterLevel, Is.Positive);
            Assert.That(encounter.AverageEncounterLevel, Is.Positive);
            Assert.That(encounter.ActualEncounterLevel, Is.Positive);

            Assert.That(encounter.AverageDifficulty, Is.Not.Empty);
            Assert.That(encounter.ActualDifficulty, Is.Not.Empty);
        }

        private void AssertCreatureType(CreatureType creatureType)
        {
            Assert.That(creatureType.Name, Is.Not.Empty);
            Assert.That(creatureType.Description, Is.Not.Null);

            Assert.That(Dice.ContainsRoll(creatureType.Name), Is.False);
            Assert.That(Dice.ContainsRoll(creatureType.Description), Is.False);

            if (creatureType.SubType != null)
                AssertCreatureType(creatureType.SubType);
        }

        [Test]
        public void TreasureDoesNotHappen()
        {
            var encounter = GenerateOrFail(() => MakeEncounterInRandomEnvironment(), e => !e.Treasures.Any());
            AssertEncounter(encounter);
            Assert.That(encounter.Treasures, Is.Empty);
        }

        [Test]
        public void TreasureHappens()
        {
            var encounter = GenerateOrFail(() => MakeEncounterInRandomEnvironment(), e => e.Treasures.Any());
            AssertEncounter(encounter);
            Assert.That(encounter.Treasures, Is.Not.Empty);
        }

        [Test]
        public void CoinHappens()
        {
            var encounter = GenerateOrFail(() => MakeEncounterInRandomEnvironment(), e => e.Treasures.Any(t => t.Coin.Quantity > 0));
            AssertEncounter(encounter);

            var coinTreasure = encounter.Treasures.First(t => t.Coin.Quantity > 0);
            Assert.That(coinTreasure.Coin.Quantity, Is.Positive);
            Assert.That(coinTreasure.Coin.Currency, Is.Not.Empty);
        }

        [Test]
        public void GoodsHappen()
        {
            var encounter = GenerateOrFail(() => MakeEncounterInRandomEnvironment(), e => e.Treasures.Any(t => t.Goods.Any()));
            AssertEncounter(encounter);

            var goodsTreasure = encounter.Treasures.First(t => t.Goods.Any());
            Assert.That(goodsTreasure.Goods, Is.Not.Empty);
        }

        [Test]
        public void ItemsHappen()
        {
            var encounter = GenerateOrFail(() => MakeEncounterInRandomEnvironment(), e => e.Treasures.Any(t => t.Items.Any()));
            AssertEncounter(encounter);

            var itemsTreasure = encounter.Treasures.First(t => t.Items.Any());
            Assert.That(itemsTreasure.Items, Is.Not.Empty);
        }

        [Test]
        public void CharactersHappen()
        {
            var encounter = GenerateOrFail(() => MakeEncounterInRandomEnvironment(), e => e.Characters.Any());
            AssertEncounter(encounter);
            Assert.That(encounter.Characters, Is.Not.Empty);
        }

        [Test]
        public void CharactersDoNotHappen()
        {
            var encounter = GenerateOrFail(() => MakeEncounterInRandomEnvironment(), e => e.Characters.Any() == false);
            AssertEncounter(encounter);
            Assert.That(encounter.Characters, Is.Empty);
        }

        [Test]
        public void SingleCreatureHappens()
        {
            var encounter = GenerateOrFail(() => MakeEncounterInRandomEnvironment(), e => e.Creatures.Count() == 1);
            AssertEncounter(encounter);
            Assert.That(encounter.Creatures.Count(), Is.EqualTo(1));
        }

        [Test]
        public void MultipleCreaturesHappen()
        {
            var encounter = GenerateOrFail(() => MakeEncounterInRandomEnvironment(), e => e.Creatures.Count() > 1);
            AssertEncounter(encounter);
            Assert.That(encounter.Creatures.Count(), Is.GreaterThan(1));
        }

        [Test]
        public void ActualDifficultySameAsAverageDifficultyHappens()
        {
            var encounter = GenerateOrFail(() => MakeEncounterInRandomEnvironment(), e => e.ActualDifficulty == e.AverageDifficulty);
            AssertEncounter(encounter);
            Assert.That(encounter.ActualDifficulty, Is.EqualTo(encounter.AverageDifficulty));
        }

        [Test]
        public void ActualDifficultyDifferentThanAverageDifficultyHappens()
        {
            var encounter = GenerateOrFail(() => MakeEncounterInRandomEnvironment(), e => e.ActualDifficulty != e.AverageDifficulty);
            AssertEncounter(encounter);

            Assert.That(encounter.ActualDifficulty, Is.Not.EqualTo(encounter.AverageDifficulty));
            Assert.That(encounter.ActualEncounterLevel, Is.Not.EqualTo(encounter.AverageEncounterLevel));
        }

        [Test]
        public void ActualEncounterLevelSameAsAverageEncounterLevelHappens()
        {
            var encounter = GenerateOrFail(() => MakeEncounterInRandomEnvironment(), e => e.ActualEncounterLevel == e.AverageEncounterLevel);
            AssertEncounter(encounter);

            Assert.That(encounter.ActualEncounterLevel, Is.EqualTo(encounter.AverageEncounterLevel));
            Assert.That(encounter.ActualDifficulty, Is.EqualTo(encounter.AverageDifficulty));
        }

        [Test]
        public void ActualEncounterLevelDifferentThanAverageEncounterLevelHappens()
        {
            var encounter = GenerateOrFail(() => MakeEncounterInRandomEnvironment(), e => e.ActualEncounterLevel != e.AverageEncounterLevel);
            AssertEncounter(encounter);
            Assert.That(encounter.ActualEncounterLevel, Is.Not.EqualTo(encounter.AverageEncounterLevel));
        }
    }
}
