﻿using EncounterGen.Common;
using EncounterGen.Tables;
using NUnit.Framework;
using System;

namespace EncounterGen.Tests.Integration.Tables.Creatures
{
    [TestFixture]
    public class CreatureGroupsTests : CollectionTests
    {
        protected override string tableName
        {
            get
            {
                return TableNameConstants.CreatureGroups;
            }
        }

        [Test]
        public override void EntriesAreComplete()
        {
            var entries = new[]
            {
                GroupConstants.RequiresSubtype,
                GroupConstants.UndeadNPC,
                CreatureConstants.Mephit,
                CreatureConstants.CelestialCreature,
                CreatureConstants.FiendishCreature,
                CreatureConstants.Skeleton,
                CreatureConstants.Zombie
            };

            AssertEntriesAreComplete(entries);
        }

        [TestCase(GroupConstants.RequiresSubtype,
            CreatureConstants.Mephit,
            CreatureConstants.CelestialCreature,
            CreatureConstants.FiendishCreature,
            CreatureConstants.Skeleton,
            CreatureConstants.Zombie)]
        [TestCase(GroupConstants.UndeadNPC,
            CreatureConstants.Lich,
            CreatureConstants.Ghost,
            CreatureConstants.Vampire)]
        [TestCase(CreatureConstants.Mephit,
            CreatureConstants.Mephit_Air,
            CreatureConstants.Mephit_Dust,
            CreatureConstants.Mephit_Earth,
            CreatureConstants.Mephit_Fire,
            CreatureConstants.Mephit_Ice,
            CreatureConstants.Mephit_Magma,
            CreatureConstants.Mephit_Ooze,
            CreatureConstants.Mephit_Salt,
            CreatureConstants.Mephit_Steam,
            CreatureConstants.Mephit_Water)]
        [TestCase(CreatureConstants.CelestialCreature,
            CreatureConstants.Androsphinx,
            CreatureConstants.Ankheg,
            CreatureConstants.Ant_Giant_Soldier,
            CreatureConstants.Ant_Giant_Worker,
            CreatureConstants.Ape,
            CreatureConstants.Ape_Dire,
            CreatureConstants.Aranea,
            CreatureConstants.AssassinVine,
            CreatureConstants.Baboon,
            CreatureConstants.Badger,
            CreatureConstants.Badger_Dire,
            CreatureConstants.Basilisk,
            CreatureConstants.Bat,
            CreatureConstants.Bat_Dire,
            CreatureConstants.Bear_Black,
            CreatureConstants.Bear_Brown,
            CreatureConstants.Bear_Dire,
            CreatureConstants.Bear_Polar,
            CreatureConstants.Bee_Giant,
            CreatureConstants.Behir,
            CreatureConstants.Bison,
            CreatureConstants.BlinkDog,
            CreatureConstants.Boar,
            CreatureConstants.Boar_Dire,
            CreatureConstants.BombardierBeetle_Giant,
            CreatureConstants.Bulette,
            CreatureConstants.Camel,
            CreatureConstants.Cat,
            CreatureConstants.Centaur,
            CreatureConstants.Centipede_Monstrous_Colossal,
            CreatureConstants.Centipede_Monstrous_Gargantuan,
            CreatureConstants.Centipede_Monstrous_Huge,
            CreatureConstants.Centipede_Monstrous_Large,
            CreatureConstants.Centipede_Monstrous_Medium,
            CreatureConstants.Centipede_Monstrous_Small,
            CreatureConstants.Centipede_Monstrous_Tiny,
            CreatureConstants.Cheetah,
            CreatureConstants.Cloaker,
            CreatureConstants.Cockatrice,
            CreatureConstants.Criosphinx,
            CreatureConstants.Crocodile,
            CreatureConstants.Crocodile_Giant,
            CreatureConstants.Cryohydra_5Heads,
            CreatureConstants.Cryohydra_6Heads,
            CreatureConstants.Cryohydra_7Heads,
            CreatureConstants.Cryohydra_8Heads,
            CreatureConstants.Cryohydra_9Heads,
            CreatureConstants.Cryohydra_10Heads,
            CreatureConstants.Cryohydra_11Heads,
            CreatureConstants.Cryohydra_12Heads,
            CreatureConstants.Darkmantle,
            CreatureConstants.Delver,
            CreatureConstants.Digester,
            CreatureConstants.Deinonychus,
            CreatureConstants.Dog,
            CreatureConstants.Donkey,
            CreatureConstants.Doppelganger,
            CreatureConstants.Dragon_Brass_Wyrmling,
            CreatureConstants.Dragon_Brass_VeryYoung,
            CreatureConstants.Dragon_Brass_Young,
            CreatureConstants.Dragon_Brass_Juvenile,
            CreatureConstants.Dragon_Brass_YoungAdult,
            CreatureConstants.Dragon_Brass_Adult,
            CreatureConstants.Dragon_Brass_MatureAdult,
            CreatureConstants.Dragon_Brass_Old,
            CreatureConstants.Dragon_Brass_VeryOld,
            CreatureConstants.Dragon_Brass_Ancient,
            CreatureConstants.Dragon_Brass_Wyrm,
            CreatureConstants.Dragon_Brass_GreatWyrm,
            CreatureConstants.Dragon_Bronze_Wyrmling,
            CreatureConstants.Dragon_Bronze_VeryYoung,
            CreatureConstants.Dragon_Bronze_Young,
            CreatureConstants.Dragon_Bronze_Juvenile,
            CreatureConstants.Dragon_Bronze_YoungAdult,
            CreatureConstants.Dragon_Bronze_Adult,
            CreatureConstants.Dragon_Bronze_MatureAdult,
            CreatureConstants.Dragon_Bronze_Old,
            CreatureConstants.Dragon_Bronze_VeryOld,
            CreatureConstants.Dragon_Bronze_Ancient,
            CreatureConstants.Dragon_Bronze_Wyrm,
            CreatureConstants.Dragon_Bronze_GreatWyrm,
            CreatureConstants.Dragon_Copper_Wyrmling,
            CreatureConstants.Dragon_Copper_VeryYoung,
            CreatureConstants.Dragon_Copper_Young,
            CreatureConstants.Dragon_Copper_Juvenile,
            CreatureConstants.Dragon_Copper_YoungAdult,
            CreatureConstants.Dragon_Copper_Adult,
            CreatureConstants.Dragon_Copper_MatureAdult,
            CreatureConstants.Dragon_Copper_Old,
            CreatureConstants.Dragon_Copper_VeryOld,
            CreatureConstants.Dragon_Copper_Ancient,
            CreatureConstants.Dragon_Copper_Wyrm,
            CreatureConstants.Dragon_Copper_GreatWyrm,
            CreatureConstants.Dragon_Gold_Wyrmling,
            CreatureConstants.Dragon_Gold_VeryYoung,
            CreatureConstants.Dragon_Gold_Young,
            CreatureConstants.Dragon_Gold_Juvenile,
            CreatureConstants.Dragon_Gold_YoungAdult,
            CreatureConstants.Dragon_Gold_Adult,
            CreatureConstants.Dragon_Gold_MatureAdult,
            CreatureConstants.Dragon_Gold_Old,
            CreatureConstants.Dragon_Gold_VeryOld,
            CreatureConstants.Dragon_Gold_Ancient,
            CreatureConstants.Dragon_Gold_Wyrm,
            CreatureConstants.Dragon_Gold_GreatWyrm,
            CreatureConstants.Dragon_Silver_Wyrmling,
            CreatureConstants.Dragon_Silver_VeryYoung,
            CreatureConstants.Dragon_Silver_Young,
            CreatureConstants.Dragon_Silver_Juvenile,
            CreatureConstants.Dragon_Silver_YoungAdult,
            CreatureConstants.Dragon_Silver_Adult,
            CreatureConstants.Dragon_Silver_MatureAdult,
            CreatureConstants.Dragon_Silver_Old,
            CreatureConstants.Dragon_Silver_VeryOld,
            CreatureConstants.Dragon_Silver_Ancient,
            CreatureConstants.Dragon_Silver_Wyrm,
            CreatureConstants.Dragon_Silver_GreatWyrm,
            CreatureConstants.Dragonne,
            CreatureConstants.Dryad,
            CreatureConstants.Dwarf,
            CreatureConstants.Eagle,
            CreatureConstants.Eagle_Giant,
            CreatureConstants.Elephant,
            CreatureConstants.Elf,
            CreatureConstants.FireBeetle_Giant,
            CreatureConstants.FrostWorm,
            CreatureConstants.Giant_Cloud,
            CreatureConstants.Giant_Stone,
            CreatureConstants.Giant_Storm,
            CreatureConstants.GibberingMouther,
            CreatureConstants.Girallon,
            CreatureConstants.Gnome,
            CreatureConstants.Gorgon,
            CreatureConstants.GrayRender,
            CreatureConstants.Grick,
            CreatureConstants.Griffon,
            CreatureConstants.Grig,
            CreatureConstants.Gynosphinx,
            CreatureConstants.Halfling,
            CreatureConstants.Hawk,
            CreatureConstants.Horse_Heavy,
            CreatureConstants.Horse_Heavy_War,
            CreatureConstants.Horse_Light,
            CreatureConstants.Horse_Light_War,
            CreatureConstants.Hippogriff,
            CreatureConstants.Hydra_5Heads,
            CreatureConstants.Hydra_6Heads,
            CreatureConstants.Hydra_7Heads,
            CreatureConstants.Hydra_8Heads,
            CreatureConstants.Hydra_9Heads,
            CreatureConstants.Hydra_10Heads,
            CreatureConstants.Hydra_11Heads,
            CreatureConstants.Hydra_12Heads,
            CreatureConstants.Hyena,
            CreatureConstants.Krenshar,
            CreatureConstants.Lammasu,
            CreatureConstants.Leopard,
            CreatureConstants.Lion,
            CreatureConstants.Lion_Dire,
            CreatureConstants.Lizard,
            CreatureConstants.Lizard_Monitor,
            CreatureConstants.Lizardfolk,
            CreatureConstants.Megaraptor,
            CreatureConstants.Mimic,
            CreatureConstants.Monkey,
            CreatureConstants.Mule,
            CreatureConstants.Naga_Guardian,
            CreatureConstants.Nymph,
            CreatureConstants.Otyugh,
            CreatureConstants.Owl,
            CreatureConstants.Owl_Giant,
            CreatureConstants.Owlbear,
            CreatureConstants.Pegasus,
            CreatureConstants.PhantomFungus,
            CreatureConstants.PhaseSpider,
            CreatureConstants.Phasm,
            CreatureConstants.Pixie,
            CreatureConstants.Pony,
            CreatureConstants.Pony_War,
            CreatureConstants.PrayingMantis_Giant,
            CreatureConstants.Pseudodragon,
            CreatureConstants.PurpleWorm,
            CreatureConstants.Pyrohydra_5Heads,
            CreatureConstants.Pyrohydra_6Heads,
            CreatureConstants.Pyrohydra_7Heads,
            CreatureConstants.Pyrohydra_8Heads,
            CreatureConstants.Pyrohydra_9Heads,
            CreatureConstants.Pyrohydra_10Heads,
            CreatureConstants.Pyrohydra_11Heads,
            CreatureConstants.Pyrohydra_12Heads,
            CreatureConstants.Rat,
            CreatureConstants.Rat_Dire,
            CreatureConstants.Raven,
            CreatureConstants.RazorBoar,
            CreatureConstants.Remorhaz,
            CreatureConstants.Rhinoceras,
            CreatureConstants.Roc,
            CreatureConstants.RustMonster,
            CreatureConstants.Satyr,
            CreatureConstants.Scorpion_Monstrous_Colossal,
            CreatureConstants.Scorpion_Monstrous_Gargantuan,
            CreatureConstants.Scorpion_Monstrous_Huge,
            CreatureConstants.Scorpion_Monstrous_Large,
            CreatureConstants.Scorpion_Monstrous_Medium,
            CreatureConstants.Scorpion_Monstrous_Small,
            CreatureConstants.Scorpion_Monstrous_Tiny,
            CreatureConstants.ShamblingMound,
            CreatureConstants.ShockerLizard,
            CreatureConstants.Shrieker,
            CreatureConstants.Snake_Constrictor,
            CreatureConstants.Snake_Constrictor_Giant,
            CreatureConstants.Snake_Viper_Huge,
            CreatureConstants.Snake_Viper_Large,
            CreatureConstants.Snake_Viper_Small,
            CreatureConstants.Snake_Viper_Medium,
            CreatureConstants.Snake_Viper_Tiny,
            CreatureConstants.Spider_Monstrous_Colossal,
            CreatureConstants.Spider_Monstrous_Gargantuan,
            CreatureConstants.Spider_Monstrous_Huge,
            CreatureConstants.Spider_Monstrous_Large,
            CreatureConstants.Spider_Monstrous_Medium,
            CreatureConstants.Spider_Monstrous_Small,
            CreatureConstants.Spider_Monstrous_Tiny,
            CreatureConstants.StagBeetle_Giant,
            CreatureConstants.SpiderEater,
            CreatureConstants.Stirge,
            CreatureConstants.Tendriculos,
            CreatureConstants.Tiger,
            CreatureConstants.Tiger_Dire,
            CreatureConstants.Toad,
            CreatureConstants.Treant,
            CreatureConstants.Triceratops,
            CreatureConstants.Tyrannosaurus,
            CreatureConstants.Unicorn,
            CreatureConstants.VioletFungus,
            CreatureConstants.Wasp_Giant,
            CreatureConstants.Weasel,
            CreatureConstants.Weasel_Dire,
            CreatureConstants.Werebear,
            CreatureConstants.Wereboar,
            CreatureConstants.Weretiger,
            CreatureConstants.Wolf,
            CreatureConstants.Wolf_Dire,
            CreatureConstants.Wolverine,
            CreatureConstants.Wolverine_Dire,
            CreatureConstants.Wyvern,
            CreatureConstants.Yrthak)]
        [TestCase(CreatureConstants.FiendishCreature,
            CreatureConstants.Mephit_Air,
            CreatureConstants.Mephit_Dust,
            CreatureConstants.Mephit_Earth,
            CreatureConstants.Mephit_Fire,
            CreatureConstants.Mephit_Ice,
            CreatureConstants.Mephit_Magma,
            CreatureConstants.Mephit_Ooze,
            CreatureConstants.Mephit_Salt,
            CreatureConstants.Mephit_Steam,
            CreatureConstants.Mephit_Water)]
        [TestCase(CreatureConstants.Skeleton,
            CreatureConstants.Mephit_Air,
            CreatureConstants.Mephit_Dust,
            CreatureConstants.Mephit_Earth,
            CreatureConstants.Mephit_Fire,
            CreatureConstants.Mephit_Ice,
            CreatureConstants.Mephit_Magma,
            CreatureConstants.Mephit_Ooze,
            CreatureConstants.Mephit_Salt,
            CreatureConstants.Mephit_Steam,
            CreatureConstants.Mephit_Water)]
        [TestCase(CreatureConstants.Zombie,
            CreatureConstants.Mephit_Air,
            CreatureConstants.Mephit_Dust,
            CreatureConstants.Mephit_Earth,
            CreatureConstants.Mephit_Fire,
            CreatureConstants.Mephit_Ice,
            CreatureConstants.Mephit_Magma,
            CreatureConstants.Mephit_Ooze,
            CreatureConstants.Mephit_Salt,
            CreatureConstants.Mephit_Steam,
            CreatureConstants.Mephit_Water)]
        public override void OrderedCollection(String entry, params String[] items)
        {
            base.Collection(entry, items);
        }
    }
}
