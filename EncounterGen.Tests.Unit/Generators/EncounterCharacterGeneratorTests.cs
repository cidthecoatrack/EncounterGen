﻿using CharacterGen.Characters;
using CharacterGen.Randomizers.Abilities;
using CharacterGen.Randomizers.Alignments;
using CharacterGen.Randomizers.CharacterClasses;
using CharacterGen.Randomizers.Races;
using EncounterGen.Common;
using EncounterGen.Domain.Generators;
using EncounterGen.Domain.Generators.Factories;
using EncounterGen.Domain.Selectors;
using EncounterGen.Domain.Selectors.Collections;
using Moq;
using NUnit.Framework;
using RollGen;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EncounterGen.Tests.Unit.Generators
{
    [TestFixture]
    public class EncounterCharacterGeneratorTests
    {
        private IEncounterCharacterGenerator encounterCharacterGenerator;
        private Mock<ICharacterGenerator> mockCharacterGenerator;
        private Mock<IAlignmentRandomizer> mockAnyAlignmentRandomizer;
        private Mock<IClassNameRandomizer> mockAnyPlayerClassNameRandomizer;
        private Mock<IClassNameRandomizer> mockAnyNPCClassNameRandomizer;
        private Mock<ISetLevelRandomizer> mockSetLevelRandomizer;
        private Mock<RaceRandomizer> mockAnyBaseRaceRandomizer;
        private Mock<RaceRandomizer> mockAnyMetaraceRandomizer;
        private Mock<ISetMetaraceRandomizer> mockSetMetaraceRandomizer;
        private Mock<ISetBaseRaceRandomizer> mockSetBaseRaceRandomizer;
        private Mock<IAbilitiesRandomizer> mockRawAbilitiesRandomizer;
        private Mock<ICollectionSelector> mockCollectionSelector;
        private Mock<ISetClassNameRandomizer> mockSetClassNameRandomizer;
        private Mock<Dice> mockDice;
        private Mock<IEncounterSelector> mockEncounterSelector;
        private List<Creature> creatures;
        private Mock<JustInTimeFactory> mockJustInTimeFactory;

        [SetUp]
        public void Setup()
        {
            mockCharacterGenerator = new Mock<ICharacterGenerator>();
            mockAnyAlignmentRandomizer = new Mock<IAlignmentRandomizer>();
            mockAnyPlayerClassNameRandomizer = new Mock<IClassNameRandomizer>();
            mockSetLevelRandomizer = new Mock<ISetLevelRandomizer>();
            mockAnyBaseRaceRandomizer = new Mock<RaceRandomizer>();
            mockAnyMetaraceRandomizer = new Mock<RaceRandomizer>();
            mockRawAbilitiesRandomizer = new Mock<IAbilitiesRandomizer>();
            mockCollectionSelector = new Mock<ICollectionSelector>();
            mockSetMetaraceRandomizer = new Mock<ISetMetaraceRandomizer>();
            mockSetClassNameRandomizer = new Mock<ISetClassNameRandomizer>();
            mockAnyNPCClassNameRandomizer = new Mock<IClassNameRandomizer>();
            mockDice = new Mock<Dice>();
            mockEncounterSelector = new Mock<IEncounterSelector>();
            mockSetBaseRaceRandomizer = new Mock<ISetBaseRaceRandomizer>();
            mockJustInTimeFactory = new Mock<JustInTimeFactory>();

            encounterCharacterGenerator = new EncounterCharacterGenerator(mockCollectionSelector.Object, mockDice.Object, mockEncounterSelector.Object, mockJustInTimeFactory.Object);

            creatures = new List<Creature>();

            creatures.Add(new Creature());
            creatures[0].Quantity = 600;
            creatures[0].Type.Name = "creature";
            creatures[0].Type.Description = "description";

            mockSetMetaraceRandomizer.SetupAllProperties();
            mockSetBaseRaceRandomizer.SetupAllProperties();
            mockSetClassNameRandomizer.SetupAllProperties();
            mockSetLevelRandomizer.SetupAllProperties();

            mockSetLevelRandomizer.Object.AllowAdjustments = true;

            mockDice.Setup(d => d.Roll(It.IsAny<string>())).Returns((string s) => ParseRoll(s));

            mockCollectionSelector.Setup(s => s.SelectRandomFrom(It.IsAny<IEnumerable<string>>())).Returns((IEnumerable<string> c) => c.Last());

            mockEncounterSelector.Setup(s => s.SelectNameFrom(creatures[0].Type.Name)).Returns(CreatureConstants.Character);
            mockEncounterSelector.Setup(s => s.SelectChallengeRatingFrom(creatures[0].Type.Name)).Returns("1337");

            mockJustInTimeFactory.Setup(f => f.Build<ICharacterGenerator>()).Returns(mockCharacterGenerator.Object);
            mockJustInTimeFactory.Setup(f => f.Build<IAlignmentRandomizer>(AlignmentRandomizerTypeConstants.Any)).Returns(mockAnyAlignmentRandomizer.Object);
            mockJustInTimeFactory.Setup(f => f.Build<IClassNameRandomizer>(ClassNameRandomizerTypeConstants.AnyPlayer)).Returns(mockAnyPlayerClassNameRandomizer.Object);
            mockJustInTimeFactory.Setup(f => f.Build<IClassNameRandomizer>(ClassNameRandomizerTypeConstants.AnyNPC)).Returns(mockAnyNPCClassNameRandomizer.Object);
            mockJustInTimeFactory.Setup(f => f.Build<ISetClassNameRandomizer>()).Returns(mockSetClassNameRandomizer.Object);
            mockJustInTimeFactory.Setup(f => f.Build<ISetLevelRandomizer>()).Returns(mockSetLevelRandomizer.Object);
            mockJustInTimeFactory.Setup(f => f.Build<RaceRandomizer>(RaceRandomizerTypeConstants.BaseRace.AnyBase)).Returns(mockAnyBaseRaceRandomizer.Object);
            mockJustInTimeFactory.Setup(f => f.Build<RaceRandomizer>(RaceRandomizerTypeConstants.Metarace.AnyMeta)).Returns(mockAnyMetaraceRandomizer.Object);
            mockJustInTimeFactory.Setup(f => f.Build<ISetBaseRaceRandomizer>()).Returns(mockSetBaseRaceRandomizer.Object);
            mockJustInTimeFactory.Setup(f => f.Build<ISetMetaraceRandomizer>()).Returns(mockSetMetaraceRandomizer.Object);
            mockJustInTimeFactory.Setup(f => f.Build<IAbilitiesRandomizer>(AbilitiesRandomizerTypeConstants.Raw)).Returns(mockRawAbilitiesRandomizer.Object);
        }

        private PartialRoll ParseRoll(string roll)
        {
            var value = 0;
            if (int.TryParse(roll, out value) == false)
                throw new ArgumentException("This roll was not set up to be parsed: " + roll);

            var mockPartialRoll = new Mock<PartialRoll>();
            mockPartialRoll.Setup(r => r.AsSum()).Returns(value);

            return mockPartialRoll.Object;
        }

        [Test]
        public void GenerateCharacters()
        {
            mockCharacterGenerator
                .Setup(g => g.GenerateWith(
                    mockAnyAlignmentRandomizer.Object,
                    mockAnyPlayerClassNameRandomizer.Object,
                    It.Is<ISetLevelRandomizer>(r => r.SetLevel == 1337 && r.AllowAdjustments),
                    mockAnyBaseRaceRandomizer.Object,
                    mockAnyMetaraceRandomizer.Object,
                    mockRawAbilitiesRandomizer.Object))
                .Returns(() => BuildCharacter(1337));

            var characters = encounterCharacterGenerator.GenerateFrom(creatures);
            Assert.That(characters, Is.Not.Null);

            Assert.That(characters, Is.All.Not.Null);
            Assert.That(characters.Count, Is.EqualTo(600));
            Assert.That(characters, Is.Unique);
            Assert.That(characters.Select(c => c.InterestingTrait), Is.Unique);
        }

        private Character BuildCharacter(int level, string className = "random class name", string metarace = "random metarace", string baseRace = "random base race")
        {
            var character = new Character();
            character.InterestingTrait = Guid.NewGuid().ToString();
            character.Class.Name = className;
            character.Class.Level = level;
            character.Race.Metarace = metarace;
            character.Race.BaseRace = baseRace;

            return character;
        }

        [Test]
        public void DoNotGenerateNonCharacters()
        {
            mockEncounterSelector.Setup(s => s.SelectNameFrom(creatures[0].Type.Name)).Returns("not a character");
            var characters = encounterCharacterGenerator.GenerateFrom(creatures);
            Assert.That(characters, Is.Empty);
        }

        [Test]
        public void GenerateCharactersWithVariableLevels()
        {
            mockEncounterSelector.Setup(s => s.SelectChallengeRatingFrom(creatures[0].Type.Name)).Returns("13d37");
            mockDice.Setup(d => d.Roll("13d37").AsSum()).Returns(1337);

            mockCharacterGenerator
                .Setup(g => g.GenerateWith(
                    mockAnyAlignmentRandomizer.Object,
                    mockAnyPlayerClassNameRandomizer.Object,
                    It.Is<ISetLevelRandomizer>(r => r.SetLevel == 1337 && r.AllowAdjustments),
                    mockAnyBaseRaceRandomizer.Object,
                    mockAnyMetaraceRandomizer.Object,
                    mockRawAbilitiesRandomizer.Object))
                .Returns(() => BuildCharacter(1337));

            var characters = encounterCharacterGenerator.GenerateFrom(creatures);
            Assert.That(characters, Is.Not.Null);
            Assert.That(characters, Is.All.Not.Null);
            Assert.That(characters.Count, Is.EqualTo(600));
            Assert.That(characters, Is.Unique);
            Assert.That(characters.Select(c => c.InterestingTrait), Is.Unique);
            Assert.That(characters.Select(c => c.Class.Level), Is.All.EqualTo(1337));
        }

        [Test]
        public void VariableLevelsAreUniquePerCharacter()
        {
            mockEncounterSelector.Setup(s => s.SelectChallengeRatingFrom(creatures[0].Type.Name)).Returns("13d37");
            creatures[0].Quantity = 2;

            mockDice.SetupSequence(d => d.Roll("13d37").AsSum()).Returns(1337).Returns(1234);

            mockCharacterGenerator
                .Setup(g => g.GenerateWith(
                    mockAnyAlignmentRandomizer.Object,
                    mockAnyPlayerClassNameRandomizer.Object,
                    It.Is<ISetLevelRandomizer>(r => r.SetLevel == 1337 && r.AllowAdjustments),
                    mockAnyBaseRaceRandomizer.Object,
                    mockAnyMetaraceRandomizer.Object,
                    mockRawAbilitiesRandomizer.Object))
                .Returns(() => BuildCharacter(1337));

            mockCharacterGenerator
                .Setup(g => g.GenerateWith(
                    mockAnyAlignmentRandomizer.Object,
                    mockAnyPlayerClassNameRandomizer.Object,
                    It.Is<ISetLevelRandomizer>(r => r.SetLevel == 1234 && r.AllowAdjustments),
                    mockAnyBaseRaceRandomizer.Object,
                    mockAnyMetaraceRandomizer.Object,
                    mockRawAbilitiesRandomizer.Object))
                .Returns(() => BuildCharacter(1234));

            var characters = encounterCharacterGenerator.GenerateFrom(creatures);
            Assert.That(characters, Is.Not.Null);
            Assert.That(characters, Is.All.Not.Null);
            Assert.That(characters.Count, Is.EqualTo(2));
            Assert.That(characters, Is.Unique);
            Assert.That(characters.Select(c => c.InterestingTrait), Is.Unique);
            Assert.That(characters.Select(c => c.Class.Level), Contains.Item(1337));
            Assert.That(characters.Select(c => c.Class.Level), Contains.Item(1234));
        }

        [Test]
        public void GenerateWithSetBaseRace()
        {
            mockEncounterSelector.Setup(s => s.SelectBaseRaceFrom(creatures[0].Type.Name)).Returns("base race");

            mockCharacterGenerator
                .Setup(g => g.GenerateWith(
                    mockAnyAlignmentRandomizer.Object,
                    mockAnyPlayerClassNameRandomizer.Object,
                    It.Is<ISetLevelRandomizer>(r => r.SetLevel == 1337 && r.AllowAdjustments == false),
                    It.Is<ISetBaseRaceRandomizer>(r => r.SetBaseRace == "base race"),
                    mockAnyMetaraceRandomizer.Object,
                    mockRawAbilitiesRandomizer.Object))
                .Returns(() => BuildCharacter(1337, baseRace: "base race"));

            var characters = encounterCharacterGenerator.GenerateFrom(creatures);
            Assert.That(characters, Is.Not.Null);
            Assert.That(characters, Is.All.Not.Null);
            Assert.That(characters.Count, Is.EqualTo(600));
            Assert.That(characters, Is.Unique);
            Assert.That(characters.Select(c => c.InterestingTrait), Is.Unique);
            Assert.That(characters.Select(c => c.Class.Level), Is.All.EqualTo(1337));
            Assert.That(characters.Select(c => c.Race.BaseRace), Is.All.EqualTo("base race"));
        }

        [Test]
        public void GenerateWithSetMetarace()
        {
            mockEncounterSelector.Setup(s => s.SelectMetaraceFrom(creatures[0].Type.Name)).Returns("metarace");

            mockCharacterGenerator
                .Setup(g => g.GenerateWith(
                    mockAnyAlignmentRandomizer.Object,
                    mockAnyPlayerClassNameRandomizer.Object,
                    It.Is<ISetLevelRandomizer>(r => r.SetLevel == 1337 && r.AllowAdjustments == false),
                    mockAnyBaseRaceRandomizer.Object,
                    It.Is<ISetMetaraceRandomizer>(r => r.SetMetarace == "metarace"),
                    mockRawAbilitiesRandomizer.Object))
                .Returns(() => BuildCharacter(1337, metarace: "metarace"));

            var characters = encounterCharacterGenerator.GenerateFrom(creatures);
            Assert.That(characters, Is.Not.Null);
            Assert.That(characters, Is.All.Not.Null);
            Assert.That(characters.Count, Is.EqualTo(600));
            Assert.That(characters, Is.Unique);
            Assert.That(characters.Select(c => c.InterestingTrait), Is.Unique);
            Assert.That(characters.Select(c => c.Class.Level), Is.All.EqualTo(1337));
            Assert.That(characters.Select(c => c.Race.Metarace), Is.All.EqualTo("metarace"));
        }

        [Test]
        public void GenerateWithSetClassName()
        {
            mockEncounterSelector.Setup(s => s.SelectCharacterClassesFrom(creatures[0].Type.Name)).Returns(new[] { "class name" });

            mockCharacterGenerator
                .Setup(g => g.GenerateWith(
                    mockAnyAlignmentRandomizer.Object,
                    It.Is<ISetClassNameRandomizer>(r => r.SetClassName == "class name"),
                    It.Is<ISetLevelRandomizer>(r => r.SetLevel == 1337 && r.AllowAdjustments),
                    mockAnyBaseRaceRandomizer.Object,
                    mockAnyMetaraceRandomizer.Object,
                    mockRawAbilitiesRandomizer.Object))
                .Returns(() => BuildCharacter(1337, "class name"));

            var characters = encounterCharacterGenerator.GenerateFrom(creatures);
            Assert.That(characters, Is.Not.Null);
            Assert.That(characters, Is.All.Not.Null);
            Assert.That(characters.Count, Is.EqualTo(600));
            Assert.That(characters, Is.Unique);
            Assert.That(characters.Select(c => c.InterestingTrait), Is.Unique);
            Assert.That(characters.Select(c => c.Class.Level), Is.All.EqualTo(1337));
            Assert.That(characters.Select(c => c.Class.Name), Is.All.EqualTo("class name"));
        }

        [Test]
        public void GenerateWithSetClassNames()
        {
            mockEncounterSelector.Setup(s => s.SelectCharacterClassesFrom(creatures[0].Type.Name)).Returns(new[] { "class name", "other class name" });

            mockCharacterGenerator
                .Setup(g => g.GenerateWith(
                    mockAnyAlignmentRandomizer.Object,
                    It.Is<ISetClassNameRandomizer>(r => r.SetClassName == "other class name"),
                    It.Is<ISetLevelRandomizer>(r => r.SetLevel == 1337 && r.AllowAdjustments),
                    mockAnyBaseRaceRandomizer.Object,
                    mockAnyMetaraceRandomizer.Object,
                    mockRawAbilitiesRandomizer.Object))
                .Returns(() => BuildCharacter(1337, "other class name"));

            var characters = encounterCharacterGenerator.GenerateFrom(creatures);
            Assert.That(characters, Is.Not.Null);
            Assert.That(characters, Is.All.Not.Null);
            Assert.That(characters.Count, Is.EqualTo(600));
            Assert.That(characters, Is.Unique);
            Assert.That(characters.Select(c => c.InterestingTrait), Is.Unique);
            Assert.That(characters.Select(c => c.Class.Level), Is.All.EqualTo(1337));
            Assert.That(characters.Select(c => c.Class.Name), Is.All.EqualTo("other class name"));
        }

        [Test]
        public void GenerateWithRandomSetClassNames()
        {
            mockEncounterSelector.Setup(s => s.SelectCharacterClassesFrom(creatures[0].Type.Name)).Returns(new[] { "class name", "other class name" });

            var index = 0;
            mockCollectionSelector.Setup(s => s.SelectRandomFrom(It.IsAny<IEnumerable<string>>())).Returns((IEnumerable<string> c) => c.ElementAt(index++ % c.Count()));

            mockCharacterGenerator
                .Setup(g => g.GenerateWith(
                    mockAnyAlignmentRandomizer.Object,
                    It.Is<ISetClassNameRandomizer>(r => r.SetClassName == "class name"),
                    It.Is<ISetLevelRandomizer>(r => r.SetLevel == 1337 && r.AllowAdjustments),
                    mockAnyBaseRaceRandomizer.Object,
                    mockAnyMetaraceRandomizer.Object,
                    mockRawAbilitiesRandomizer.Object))
                .Returns(() => BuildCharacter(1337, "class name"));

            mockCharacterGenerator
                .Setup(g => g.GenerateWith(
                    mockAnyAlignmentRandomizer.Object,
                    It.Is<ISetClassNameRandomizer>(r => r.SetClassName == "other class name"),
                    It.Is<ISetLevelRandomizer>(r => r.SetLevel == 1337 && r.AllowAdjustments),
                    mockAnyBaseRaceRandomizer.Object,
                    mockAnyMetaraceRandomizer.Object,
                    mockRawAbilitiesRandomizer.Object))
                .Returns(() => BuildCharacter(1337, "other class name"));

            var characters = encounterCharacterGenerator.GenerateFrom(creatures);
            Assert.That(characters, Is.Not.Null);
            Assert.That(characters, Is.All.Not.Null);
            Assert.That(characters.Count, Is.EqualTo(600));
            Assert.That(characters, Is.Unique);
            Assert.That(characters.Select(c => c.InterestingTrait), Is.Unique);
            Assert.That(characters.Select(c => c.Class.Level), Is.All.EqualTo(1337));
            Assert.That(characters.Select(c => c.Class.Name), Contains.Item("class name"));
            Assert.That(characters.Select(c => c.Class.Name), Contains.Item("other class name"));
        }

        [Test]
        public void GenerateSetToAnyNPC()
        {
            mockEncounterSelector.Setup(s => s.SelectCharacterClassesFrom(creatures[0].Type.Name)).Returns(new[] { ClassNameRandomizerTypeConstants.AnyNPC });

            mockCharacterGenerator
                .Setup(g => g.GenerateWith(
                    mockAnyAlignmentRandomizer.Object,
                    mockAnyNPCClassNameRandomizer.Object,
                    It.Is<ISetLevelRandomizer>(r => r.SetLevel == 1337 && r.AllowAdjustments),
                    mockAnyBaseRaceRandomizer.Object,
                    mockAnyMetaraceRandomizer.Object,
                    mockRawAbilitiesRandomizer.Object))
                .Returns(() => BuildCharacter(1337));

            var characters = encounterCharacterGenerator.GenerateFrom(creatures);
            Assert.That(characters, Is.Not.Null);
            Assert.That(characters, Is.All.Not.Null);
            Assert.That(characters.Count, Is.EqualTo(600));
            Assert.That(characters, Is.Unique);
            Assert.That(characters.Select(c => c.InterestingTrait), Is.Unique);
            Assert.That(characters.Select(c => c.Class.Level), Is.All.EqualTo(1337));
        }

        [Test]
        public void GenerateWithEverything()
        {
            mockEncounterSelector.Setup(s => s.SelectCharacterClassesFrom(creatures[0].Type.Name)).Returns(new[] { "class name", "other class name" });
            mockEncounterSelector.Setup(s => s.SelectChallengeRatingFrom(creatures[0].Type.Name)).Returns("13d37");
            mockEncounterSelector.Setup(s => s.SelectBaseRaceFrom(creatures[0].Type.Name)).Returns("base race");
            mockEncounterSelector.Setup(s => s.SelectMetaraceFrom(creatures[0].Type.Name)).Returns("metarace");

            var roll = 0;
            mockDice.Setup(d => d.Roll("13d37").AsSum()).Returns(() => roll++ % 2 + 1);

            var index = 0;
            mockCollectionSelector.Setup(s => s.SelectRandomFrom(It.IsAny<IEnumerable<string>>())).Returns((IEnumerable<string> c) => c.ElementAt(index++ % c.Count()));

            mockCharacterGenerator
                .Setup(g => g.GenerateWith(
                    mockAnyAlignmentRandomizer.Object,
                    It.Is<ISetClassNameRandomizer>(r => r.SetClassName == "class name"),
                    It.Is<ISetLevelRandomizer>(r => r.SetLevel == 1 && r.AllowAdjustments == false),
                    It.Is<ISetBaseRaceRandomizer>(r => r.SetBaseRace == "base race"),
                    It.Is<ISetMetaraceRandomizer>(r => r.SetMetarace == "metarace"),
                    mockRawAbilitiesRandomizer.Object))
                .Returns(() => BuildCharacter(1, "class name", "metarace", "base race"));

            mockCharacterGenerator
                .Setup(g => g.GenerateWith(
                    mockAnyAlignmentRandomizer.Object,
                    It.Is<ISetClassNameRandomizer>(r => r.SetClassName == "other class name"),
                    It.Is<ISetLevelRandomizer>(r => r.SetLevel == 2 && r.AllowAdjustments == false),
                    It.Is<ISetBaseRaceRandomizer>(r => r.SetBaseRace == "base race"),
                    It.Is<ISetMetaraceRandomizer>(r => r.SetMetarace == "metarace"),
                    mockRawAbilitiesRandomizer.Object))
                .Returns(() => BuildCharacter(2, "other class name", "metarace", "base race"));

            mockCharacterGenerator
                .Setup(g => g.GenerateWith(
                    mockAnyAlignmentRandomizer.Object,
                    It.Is<ISetClassNameRandomizer>(r => r.SetClassName == "class name"),
                    It.Is<ISetLevelRandomizer>(r => r.SetLevel == 2 && r.AllowAdjustments == false),
                    It.Is<ISetBaseRaceRandomizer>(r => r.SetBaseRace == "base race"),
                    It.Is<ISetMetaraceRandomizer>(r => r.SetMetarace == "metarace"),
                    mockRawAbilitiesRandomizer.Object))
                .Returns(() => BuildCharacter(2, "class name", "metarace", "base race"));

            mockCharacterGenerator
                .Setup(g => g.GenerateWith(
                    mockAnyAlignmentRandomizer.Object,
                    It.Is<ISetClassNameRandomizer>(r => r.SetClassName == "other class name"),
                    It.Is<ISetLevelRandomizer>(r => r.SetLevel == 1 && r.AllowAdjustments == false),
                    It.Is<ISetBaseRaceRandomizer>(r => r.SetBaseRace == "base race"),
                    It.Is<ISetMetaraceRandomizer>(r => r.SetMetarace == "metarace"),
                    mockRawAbilitiesRandomizer.Object))
                .Returns(() => BuildCharacter(1, "other class name", "metarace", "base race"));

            var characters = encounterCharacterGenerator.GenerateFrom(creatures);
            Assert.That(characters, Is.Not.Null);
            Assert.That(characters, Is.All.Not.Null);
            Assert.That(characters.Count, Is.EqualTo(600));
            Assert.That(characters, Is.Unique);
            Assert.That(characters.Select(c => c.InterestingTrait), Is.Unique);
            Assert.That(characters.Select(c => c.Class.Level), Contains.Item(1));
            Assert.That(characters.Select(c => c.Class.Level), Contains.Item(2));
            Assert.That(characters.Select(c => c.Class.Name), Contains.Item("class name"));
            Assert.That(characters.Select(c => c.Class.Name), Contains.Item("other class name"));
            Assert.That(characters.Select(c => c.Race.Metarace), Is.All.EqualTo("metarace"));
            Assert.That(characters.Select(c => c.Race.BaseRace), Is.All.EqualTo("base race"));
        }

        [Test]
        public void GenerateWithNothingAfterEverything()
        {
            mockEncounterSelector.Setup(s => s.SelectCharacterClassesFrom(creatures[0].Type.Name)).Returns(new[] { "class name", "other class name" });
            mockEncounterSelector.Setup(s => s.SelectChallengeRatingFrom(creatures[0].Type.Name)).Returns("13d37");
            mockEncounterSelector.Setup(s => s.SelectBaseRaceFrom(creatures[0].Type.Name)).Returns("base race");
            mockEncounterSelector.Setup(s => s.SelectMetaraceFrom(creatures[0].Type.Name)).Returns("metarace");

            var roll = 0;
            mockDice.Setup(d => d.Roll("13d37").AsSum()).Returns(() => roll++ % 2 + 1);

            var index = 0;
            mockCollectionSelector.Setup(s => s.SelectRandomFrom(It.IsAny<IEnumerable<string>>())).Returns((IEnumerable<string> c) => c.ElementAt(index++ % c.Count()));

            mockCharacterGenerator
                .Setup(g => g.GenerateWith(
                    mockAnyAlignmentRandomizer.Object,
                    It.Is<ISetClassNameRandomizer>(r => r.SetClassName == "class name"),
                    It.Is<ISetLevelRandomizer>(r => r.SetLevel == 1 && r.AllowAdjustments == false),
                    It.Is<ISetBaseRaceRandomizer>(r => r.SetBaseRace == "base race"),
                    It.Is<ISetMetaraceRandomizer>(r => r.SetMetarace == "metarace"),
                    mockRawAbilitiesRandomizer.Object))
                .Returns(() => BuildCharacter(1, "class name", "metarace", "base race"));

            mockCharacterGenerator
                .Setup(g => g.GenerateWith(
                    mockAnyAlignmentRandomizer.Object,
                    It.Is<ISetClassNameRandomizer>(r => r.SetClassName == "other class name"),
                    It.Is<ISetLevelRandomizer>(r => r.SetLevel == 2 && r.AllowAdjustments == false),
                    It.Is<ISetBaseRaceRandomizer>(r => r.SetBaseRace == "base race"),
                    It.Is<ISetMetaraceRandomizer>(r => r.SetMetarace == "metarace"),
                    mockRawAbilitiesRandomizer.Object))
                .Returns(() => BuildCharacter(2, "other class name", "metarace", "base race"));

            mockCharacterGenerator
                .Setup(g => g.GenerateWith(
                    mockAnyAlignmentRandomizer.Object,
                    It.Is<ISetClassNameRandomizer>(r => r.SetClassName == "class name"),
                    It.Is<ISetLevelRandomizer>(r => r.SetLevel == 2 && r.AllowAdjustments == false),
                    It.Is<ISetBaseRaceRandomizer>(r => r.SetBaseRace == "base race"),
                    It.Is<ISetMetaraceRandomizer>(r => r.SetMetarace == "metarace"),
                    mockRawAbilitiesRandomizer.Object))
                .Returns(() => BuildCharacter(2, "class name", "metarace", "base race"));

            mockCharacterGenerator
                .Setup(g => g.GenerateWith(
                    mockAnyAlignmentRandomizer.Object,
                    It.Is<ISetClassNameRandomizer>(r => r.SetClassName == "other class name"),
                    It.Is<ISetLevelRandomizer>(r => r.SetLevel == 1 && r.AllowAdjustments == false),
                    It.Is<ISetBaseRaceRandomizer>(r => r.SetBaseRace == "base race"),
                    It.Is<ISetMetaraceRandomizer>(r => r.SetMetarace == "metarace"),
                    mockRawAbilitiesRandomizer.Object))
                .Returns(() => BuildCharacter(1, "other class name", "metarace", "base race"));

            var characters = encounterCharacterGenerator.GenerateFrom(creatures);
            Assert.That(characters, Is.Not.Null);
            Assert.That(characters, Is.All.Not.Null);
            Assert.That(characters.Count, Is.EqualTo(600));
            Assert.That(characters, Is.Unique);
            Assert.That(characters.Select(c => c.InterestingTrait), Is.Unique);
            Assert.That(characters.Select(c => c.Class.Level), Contains.Item(1));
            Assert.That(characters.Select(c => c.Class.Level), Contains.Item(2));
            Assert.That(characters.Select(c => c.Class.Name), Contains.Item("class name"));
            Assert.That(characters.Select(c => c.Class.Name), Contains.Item("other class name"));
            Assert.That(characters.Select(c => c.Race.Metarace), Is.All.EqualTo("metarace"));
            Assert.That(characters.Select(c => c.Race.BaseRace), Is.All.EqualTo("base race"));

            mockEncounterSelector.Setup(s => s.SelectCharacterClassesFrom(creatures[0].Type.Name)).Returns(Enumerable.Empty<string>());
            mockEncounterSelector.Setup(s => s.SelectChallengeRatingFrom(creatures[0].Type.Name)).Returns("1337");
            mockEncounterSelector.Setup(s => s.SelectBaseRaceFrom(creatures[0].Type.Name)).Returns(string.Empty);
            mockEncounterSelector.Setup(s => s.SelectMetaraceFrom(creatures[0].Type.Name)).Returns(string.Empty);

            mockCharacterGenerator
                .Setup(g => g.GenerateWith(
                    mockAnyAlignmentRandomizer.Object,
                    mockAnyPlayerClassNameRandomizer.Object,
                    It.Is<ISetLevelRandomizer>(r => r.SetLevel == 1337 && r.AllowAdjustments),
                    mockAnyBaseRaceRandomizer.Object,
                    mockAnyMetaraceRandomizer.Object,
                    mockRawAbilitiesRandomizer.Object))
                .Returns(() => BuildCharacter(1337));

            characters = encounterCharacterGenerator.GenerateFrom(creatures);
            Assert.That(characters, Is.Not.Null);
            Assert.That(characters, Is.All.Not.Null);
            Assert.That(characters.Count, Is.EqualTo(600));
            Assert.That(characters, Is.Unique);
            Assert.That(characters.Select(c => c.InterestingTrait), Is.Unique);
            Assert.That(characters.Select(c => c.Class.Level), Is.All.EqualTo(1337));
            Assert.That(characters.Select(c => c.Class.Name), Is.All.EqualTo("random class name"));
            Assert.That(characters.Select(c => c.Race.Metarace), Is.All.EqualTo("random metarace"));
            Assert.That(characters.Select(c => c.Race.BaseRace), Is.All.EqualTo("random base race"));
        }

        [Test]
        public void GenerateCharactersFromSubtype()
        {
            creatures[0].Type.Name = "other creature";
            creatures[0].Type.SubType = new CreatureType();
            creatures[0].Type.SubType.Name = "creature";

            mockCharacterGenerator
                .Setup(g => g.GenerateWith(
                    mockAnyAlignmentRandomizer.Object,
                    mockAnyPlayerClassNameRandomizer.Object,
                    It.Is<ISetLevelRandomizer>(r => r.SetLevel == 1337 && r.AllowAdjustments),
                    mockAnyBaseRaceRandomizer.Object,
                    mockAnyMetaraceRandomizer.Object,
                    mockRawAbilitiesRandomizer.Object))
                .Returns(() => BuildCharacter(1337));

            var characters = encounterCharacterGenerator.GenerateFrom(creatures);
            Assert.That(characters, Is.Not.Null);
            Assert.That(characters.Count, Is.EqualTo(600));
            Assert.That(characters, Is.Unique);
            Assert.That(characters.Select(c => c.InterestingTrait), Is.Unique);
        }

        [Test]
        public void GenerateMultipleTypesOfCharacters()
        {
            creatures.Add(new Creature());
            creatures.Add(new Creature());
            creatures.Add(new Creature());
            creatures.Add(new Creature());
            creatures.Add(new Creature());
            creatures.Add(new Creature());
            creatures.Add(new Creature());

            creatures[1].Type.Name = "any npc creature";
            creatures[1].Quantity = 12;
            creatures[2].Type.Name = "set class creature";
            creatures[2].Quantity = 9;
            creatures[3].Type.Name = "set base race creature";
            creatures[3].Quantity = 11;
            creatures[4].Type.Name = "set metarace creature";
            creatures[4].Quantity = 10;
            creatures[5].Type.Name = "random class creature";
            creatures[5].Quantity = 7;
            creatures[6].Type.Name = "random level creature";
            creatures[6].Quantity = 8;
            creatures[7].Type.Name = "not a character";
            creatures[7].Quantity = 13;

            mockEncounterSelector.Setup(s => s.SelectNameFrom(creatures[1].Type.Name)).Returns(CreatureConstants.Character);
            mockEncounterSelector.Setup(s => s.SelectChallengeRatingFrom(creatures[1].Type.Name)).Returns("1337");
            mockEncounterSelector.Setup(s => s.SelectCharacterClassesFrom(creatures[1].Type.Name)).Returns(new[] { ClassNameRandomizerTypeConstants.AnyNPC });

            mockEncounterSelector.Setup(s => s.SelectNameFrom(creatures[2].Type.Name)).Returns(CreatureConstants.Character);
            mockEncounterSelector.Setup(s => s.SelectChallengeRatingFrom(creatures[2].Type.Name)).Returns("1337");
            mockEncounterSelector.Setup(s => s.SelectCharacterClassesFrom(creatures[2].Type.Name)).Returns(new[] { "class name" });

            mockEncounterSelector.Setup(s => s.SelectNameFrom(creatures[3].Type.Name)).Returns(CreatureConstants.Character);
            mockEncounterSelector.Setup(s => s.SelectChallengeRatingFrom(creatures[3].Type.Name)).Returns("1337");
            mockEncounterSelector.Setup(s => s.SelectBaseRaceFrom(creatures[3].Type.Name)).Returns("base race");

            mockEncounterSelector.Setup(s => s.SelectNameFrom(creatures[4].Type.Name)).Returns(CreatureConstants.Character);
            mockEncounterSelector.Setup(s => s.SelectChallengeRatingFrom(creatures[4].Type.Name)).Returns("1337");
            mockEncounterSelector.Setup(s => s.SelectMetaraceFrom(creatures[4].Type.Name)).Returns("metarace");

            mockEncounterSelector.Setup(s => s.SelectNameFrom(creatures[5].Type.Name)).Returns(CreatureConstants.Character);
            mockEncounterSelector.Setup(s => s.SelectChallengeRatingFrom(creatures[5].Type.Name)).Returns("1337");
            mockEncounterSelector.Setup(s => s.SelectCharacterClassesFrom(creatures[5].Type.Name)).Returns(new[] { "class name", "other class name" });

            mockEncounterSelector.Setup(s => s.SelectNameFrom(creatures[6].Type.Name)).Returns(CreatureConstants.Character);
            mockEncounterSelector.Setup(s => s.SelectChallengeRatingFrom(creatures[6].Type.Name)).Returns("13d37");

            mockEncounterSelector.Setup(s => s.SelectNameFrom(creatures[7].Type.Name)).Returns("really not a character");

            var roll = 0;
            mockDice.Setup(d => d.Roll("13d37").AsSum()).Returns(() => roll++ % 2 + 1);

            var index = 0;
            mockCollectionSelector.Setup(s => s.SelectRandomFrom(It.IsAny<IEnumerable<string>>())).Returns((IEnumerable<string> c) => c.ElementAt(index++ % c.Count()));

            var level = 1;
            mockCharacterGenerator
                .Setup(g => g.GenerateWith(
                    mockAnyAlignmentRandomizer.Object,
                    It.IsAny<IClassNameRandomizer>(),
                    mockSetLevelRandomizer.Object,
                    It.IsAny<RaceRandomizer>(),
                    It.IsAny<RaceRandomizer>(),
                    mockRawAbilitiesRandomizer.Object))
                .Returns(() => BuildCharacter(level++));

            var characters = encounterCharacterGenerator.GenerateFrom(creatures);
            Assert.That(characters, Is.Not.Null);
            Assert.That(characters, Is.All.Not.Null);
            Assert.That(characters.Count, Is.EqualTo(657));
            Assert.That(characters, Is.Unique);
            Assert.That(characters.Select(c => c.InterestingTrait), Is.Unique);

            var levels = Enumerable.Range(1, 657);
            Assert.That(characters.Select(c => c.Class.Level), Is.EquivalentTo(levels));
        }

        [Test]
        public void WholeCreatureTypeMustMatchToBeCharacter()
        {
            creatures[0].Type.Name = $"{CreatureConstants.Character} but not really[6789]";

            var characters = encounterCharacterGenerator.GenerateFrom(creatures);
            Assert.That(characters, Is.Not.Null);
            Assert.That(characters, Is.Empty);
        }

        [Test]
        public void NotSpecifyingLevelForCharacterThrowsException()
        {
            mockEncounterSelector.Setup(s => s.SelectChallengeRatingFrom(creatures[0].Type.Name)).Returns(string.Empty);
            Assert.That(() => encounterCharacterGenerator.GenerateFrom(creatures), Throws.InstanceOf<ArgumentException>().With.Message.EqualTo("Character level was not provided for a character creature"));
        }
    }
}
