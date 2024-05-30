﻿using DnDGen.EncounterGen.Models;
using DnDGen.EncounterGen.Selectors;
using DnDGen.EncounterGen.Tables;
using DnDGen.Infrastructure.Mappers.Collections;
using DnDGen.Infrastructure.Selectors.Collections;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace DnDGen.EncounterGen.Tests.Integration.Tables
{
    [TestFixture]
    public abstract class CollectionTests : TableTests
    {
        internal CollectionMapper collectionMapper;
        internal ICollectionSelector collectionSelector;
        internal IEncounterFormatter encounterFormatter;

        protected Dictionary<string, IEnumerable<string>> table;

        [SetUp]
        public void CollectionSetup()
        {
            collectionMapper = GetNewInstanceOf<CollectionMapper>();
            collectionSelector = GetNewInstanceOf<ICollectionSelector>();
            encounterFormatter = GetNewInstanceOf<IEncounterFormatter>();

            table = collectionMapper.Map(tableName);
        }

        public abstract void EntriesAreComplete();

        protected void AssertEntriesAreComplete(IEnumerable<string> entries)
        {
            Assert.That(entries, Is.Unique);
            Assert.That(table.Keys, Is.Unique);
            AssertCollection(entries, table.Keys);
        }

        protected IEnumerable<string> GetEntries()
        {
            return table.Keys;
        }

        protected IEnumerable<string> GetCollection(string entry)
        {
            return table[entry];
        }

        protected IEnumerable<string> ExplodeCollection(string name)
        {
            if (collectionSelector.IsCollection(tableName, name))
                return collectionSelector.Explode(tableName, name);

            return new[] { name };
        }

        protected IEnumerable<string> ExplodeCollections(IEnumerable<string> names)
        {
            var collection = new List<string>();

            foreach (var name in names)
            {
                var explodedCollection = ExplodeCollection(name);
                collection.AddRange(explodedCollection);
            }

            return collection.Distinct();
        }

        protected IEnumerable<string> GetAllCreaturesFromEncounters()
        {
            var creaturesAndAmounts = collectionSelector.SelectAllFrom(TableNameConstants.EncounterCreatures);
            var allCreatures = creaturesAndAmounts.Values.SelectMany(e => encounterFormatter.SelectCreaturesAndAmountsFrom(e).Keys);

            //INFO: These are creatues that do not explicitly appear in encounters, but we wish to include them anyway
            var extraCreatures = new[]
            {
                CreatureDataConstants.DominatedCreature_CR1,
                CreatureDataConstants.DominatedCreature_CR2,
                CreatureDataConstants.DominatedCreature_CR3,
                CreatureDataConstants.DominatedCreature_CR5,
                CreatureDataConstants.DominatedCreature_CR6,
                CreatureDataConstants.Mephit_Air,
                CreatureDataConstants.Mephit_Dust,
                CreatureDataConstants.Mephit_Earth,
                CreatureDataConstants.Mephit_Fire,
                CreatureDataConstants.Mephit_Ice,
                CreatureDataConstants.Mephit_Magma,
                CreatureDataConstants.Mephit_Ooze,
                CreatureDataConstants.Mephit_Salt,
                CreatureDataConstants.Mephit_Steam,
                CreatureDataConstants.Mephit_Water,
            };

            allCreatures = allCreatures.Union(extraCreatures);

            return allCreatures;
        }

        protected void AssertCollection(IEnumerable<string> expected, IEnumerable<string> actual)
        {
            Assert.That(actual, Is.EquivalentTo(expected));
        }

        protected void AssertOrderedCollection(IEnumerable<string> expected, IEnumerable<string> actual)
        {
            Assert.That(actual, Is.EqualTo(expected));
        }

        protected void AssertContainedCollection(IEnumerable<string> contained, IEnumerable<string> container)
        {
            Assert.That(contained, Is.SubsetOf(container));
        }

        public virtual void AssertDistinctCollection(IEnumerable<string> expected, IEnumerable<string> actual)
        {
            Assert.That(expected, Is.Unique, "Expected");
            Assert.That(actual, Is.Unique, "Actual");
            AssertCollection(expected, actual);
        }

        public virtual void AssertCollection(string entry, params string[] items)
        {
            Assert.That(table, Contains.Key(entry));
            AssertCollection(items, table[entry]);
        }

        public virtual void AssertDistinctCollection(string entry, params string[] items)
        {
            Assert.That(table, Contains.Key(entry));
            AssertDistinctCollection(items, table[entry]);
        }

        public virtual void AssertOrderedCollection(string entry, params string[] items)
        {
            Assert.That(table, Contains.Key(entry));
            AssertOrderedCollection(items, table[entry]);
        }
    }
}
