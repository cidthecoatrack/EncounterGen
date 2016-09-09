﻿using EncounterGen.Domain.Selectors;
using EncounterGen.Domain.Tables;
using NUnit.Framework;
using System;

namespace EncounterGen.Tests.Integration.Tables.EffectiveLevels
{
    [TestFixture]
    public class Level17EncounterLevelTests : TypeAndAmountPercentileTests
    {
        protected override String tableName
        {
            get
            {
                return String.Format(TableNameConstants.LevelXEncounterLevel, 17);
            }
        }

        [Test]
        public override void TableIsComplete()
        {
            AssertTableIsComplete();
        }

        [TestCase(1, 5, 13, ModifierConstants.Quadruple)]
        [TestCase(6, 10, 14, ModifierConstants.Triple)]
        [TestCase(11, 20, 15, ModifierConstants.Double)]
        [TestCase(21, 30, 16, ModifierConstants.HalfAgain)]
        [TestCase(31, 70, 17, ModifierConstants.Same)]
        [TestCase(71, 80, 18, ModifierConstants.TwoThirds)]
        [TestCase(81, 90, 19, ModifierConstants.Half)]
        [TestCase(91, 100, 20, ModifierConstants.OneThird)]
        public void Percentile(Int32 lower, Int32 upper, Int32 type, Int32 amount)
        {
            base.Percentile(lower, upper, type.ToString(), amount.ToString());
        }
    }
}