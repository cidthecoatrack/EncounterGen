﻿using EncounterGen.Tables;
using NUnit.Framework;
using System;

namespace EncounterGen.Tests.Unit.Tables
{
    [TestFixture]
    public class TableNameConstantsTests
    {
        [TestCase(TableNameConstants.LevelXDragons, "Level{0}Dragons")]
        [TestCase(TableNameConstants.LevelXEncounterLevel, "Level{0}EncounterLevel")]
        [TestCase(TableNameConstants.LevelXENVIRONMENTEncounters, "Level{0}{1}Encounters")]
        [TestCase(TableNameConstants.LevelXUndeadNPC, "Level{0}UndeadNPC")]
        [TestCase(TableNameConstants.MonsterGroups, "MonsterGroups")]
        [TestCase(TableNameConstants.PartialTreasure, "PartialTreasure")]
        [TestCase(TableNameConstants.RollOrder, "RollOrder")]
        [TestCase(TableNameConstants.TreasureAdjustment, "TreasureAdjustment")]
        public void Constant(String constant, String value)
        {
            Assert.That(constant, Is.EqualTo(value));
        }
    }
}
