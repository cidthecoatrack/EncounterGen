﻿using DnDGen.EncounterGen.Models;
using DnDGen.EncounterGen.Tables;
using NUnit.Framework;

namespace DnDGen.EncounterGen.Tests.Integration.Tables.Creatures.CreatureGroups
{
    [TestFixture]
    public class EnvironmentCreatureGroupsTests : CreatureGroupsTableTests
    {
        [Test]
        public override void EntriesAreComplete()
        {
            AssertCreatureGroupEntriesAreComplete();
        }

        [TestCase(EnvironmentConstants.Aquatic,
            CreatureConstants.Gargoyle_Kapoacinth,
            CreatureConstants.Ghoul_Lacedon)]
        [TestCase(EnvironmentConstants.Underground + EnvironmentConstants.Aquatic,
            CreatureConstants.Aboleth,
            CreatureConstants.Skum)]
        [TestCase(EnvironmentConstants.Civilized,
            CreatureConstants.Cat,
            CreatureConstants.Character,
            CreatureConstants.Dog,
            CreatureConstants.NPC_Traveler,
            CreatureConstants.Donkey,
            CreatureConstants.Horse,
            CreatureConstants.Livestock,
            CreatureConstants.Mule,
            CreatureConstants.Pony)]
        [TestCase(EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Aquatic,
            CreatureConstants.Shark,
            CreatureConstants.Troll_Scrag,
            CreatureConstants.Whale_Orca)]
        [TestCase(EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Civilized)]
        [TestCase(EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Desert,
            CreatureConstants.Remorhaz)]
        [TestCase(EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Forest,
            CreatureConstants.Bear_Brown,
            CreatureConstants.WinterWolf,
            CreatureConstants.Wolverine)]
        [TestCase(EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Hills,
            CreatureConstants.Beholder,
            CreatureConstants.Ettin,
            CreatureConstants.Skeleton_Ettin,
            CreatureConstants.OgreMage)]
        [TestCase(EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Marsh,
            CreatureConstants.Annis,
            CreatureConstants.Cryohydra,
            CreatureConstants.Ooze_Gray)]
        [TestCase(EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain,
            CreatureConstants.Dragon_White,
            CreatureConstants.Skeleton_Troll,
            CreatureConstants.Giant_Frost,
            CreatureConstants.Troll)]
        [TestCase(EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Plains,
            CreatureConstants.Bear_Polar,
            CreatureConstants.FrostWorm)]
        [TestCase(EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Underground)]
        [TestCase(EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic,
            CreatureConstants.DragonTurtle,
            CreatureConstants.Elf_Aquatic,
            CreatureConstants.Kraken,
            CreatureConstants.KuoToa,
            CreatureConstants.Merfolk,
            CreatureConstants.Naga_Water,
            CreatureConstants.Nixie,
            CreatureConstants.Ogre_Merrow,
            CreatureConstants.Porpoise,
            CreatureConstants.SeaCat,
            CreatureConstants.SeaHag,
            CreatureConstants.Squid,
            CreatureConstants.Triton,
            CreatureConstants.Whale_Cachalot)]
        [TestCase(EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Civilized)]
        [TestCase(EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Desert,
            CreatureConstants.Bat,
            CreatureConstants.Dragon_Blue,
            CreatureConstants.Dragonne,
            CreatureConstants.Donkey,
            CreatureConstants.Lamia,
            CreatureConstants.Lammasu)]
        [TestCase(EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Underground)]
        [TestCase(EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Aquatic,
            CreatureConstants.Elasmosaurus,
            CreatureConstants.Locathah,
            CreatureConstants.MantaRay,
            CreatureConstants.Octopus,
            CreatureConstants.Sahuagin,
            CreatureConstants.Whale_Baleen)]
        [TestCase(EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Civilized)]
        [TestCase(EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Underground)]
        [TestCase(EnvironmentConstants.Plane_Air,
            CreatureConstants.Arrowhawk,
            CreatureConstants.Belker,
            CreatureConstants.Djinni,
            CreatureConstants.Elemental_Air,
            CreatureConstants.InvisibleStalker,
            CreatureConstants.Mephit_Air,
            CreatureConstants.Mephit_Dust,
            CreatureConstants.Mephit_Ice)]
        [TestCase(EnvironmentConstants.Plane_Astral,
            CreatureConstants.Githyanki)]
        [TestCase(EnvironmentConstants.Plane_Chaotic,
            CreatureConstants.Howler,
            CreatureConstants.Lillend)]
        [TestCase(EnvironmentConstants.Plane_ChaoticEvil,
            CreatureConstants.Demon,
            CreatureConstants.Basilisk_AbyssalGreater,
            CreatureConstants.Bodak)]
        [TestCase(EnvironmentConstants.Plane_ChaoticGood,
            CreatureConstants.Bralani,
            CreatureConstants.Ghaele,
            CreatureConstants.Titan,
            CreatureConstants.Unicorn_CelestialCharger)]
        [TestCase(EnvironmentConstants.Plane_Earth,
            CreatureConstants.Xorn,
            CreatureConstants.Elemental_Earth,
            CreatureConstants.Mephit_Earth,
            CreatureConstants.Mephit_Salt)]
        [TestCase(EnvironmentConstants.Plane_Ethereal,
            CreatureConstants.EtherealMarauder,
            CreatureConstants.Xill)]
        [TestCase(EnvironmentConstants.Plane_Evil,
            CreatureConstants.FiendishCreature,
            CreatureConstants.Barghest,
            CreatureConstants.Hellwasp,
            CreatureConstants.NightHag,
            CreatureConstants.Nightmare,
            CreatureConstants.YethHound,
            CreatureConstants.Vargouille)]
        [TestCase(EnvironmentConstants.Plane_Fire,
            CreatureConstants.Azer,
            CreatureConstants.Elemental_Fire,
            CreatureConstants.Salamander,
            CreatureConstants.Efreeti,
            CreatureConstants.Magmin,
            CreatureConstants.Mephit_Fire,
            CreatureConstants.Mephit_Magma,
            CreatureConstants.Mephit_Steam,
            CreatureConstants.Rast,
            CreatureConstants.Thoqqua)]
        [TestCase(EnvironmentConstants.Plane_Good,
            CreatureConstants.Angel,
            CreatureConstants.Avoral,
            CreatureConstants.CelestialCreature,
            CreatureConstants.Leonal)]
        [TestCase(EnvironmentConstants.Plane_Lawful,
            CreatureConstants.Achaierai,
            CreatureConstants.Formian,
            CreatureConstants.Inevitable)]
        [TestCase(EnvironmentConstants.Plane_LawfulEvil,
            CreatureConstants.Devil,
            CreatureConstants.HellHound,
            CreatureConstants.NessianWarhound)]
        [TestCase(EnvironmentConstants.Plane_LawfulGood,
            CreatureConstants.Archon,
            CreatureConstants.Lammasu_GoldenProtector)]
        [TestCase(EnvironmentConstants.Plane_Limbo,
            CreatureConstants.ChaosBeast,
            CreatureConstants.Githzerai,
            CreatureConstants.Slaad)]
        [TestCase(EnvironmentConstants.Plane_NeutralEvil,
            CreatureConstants.Nightmare_Cauchemar)]
        [TestCase(EnvironmentConstants.Plane_PositiveEnergy,
            CreatureConstants.Ravid)]
        [TestCase(EnvironmentConstants.Plane_Shadow,
            CreatureConstants.Nightshade,
            CreatureConstants.ShadowMastiff)]
        [TestCase(EnvironmentConstants.Plane_Water,
            CreatureConstants.Tojanida,
            CreatureConstants.Elemental_Water,
            CreatureConstants.Mephit_Ooze,
            CreatureConstants.Mephit_Water)]
        [TestCase(GroupConstants.Extraplanar,
            EnvironmentConstants.Plane_Air,
            EnvironmentConstants.Plane_Astral,
            EnvironmentConstants.Plane_Chaotic,
            EnvironmentConstants.Plane_ChaoticEvil,
            EnvironmentConstants.Plane_ChaoticGood,
            EnvironmentConstants.Plane_Earth,
            EnvironmentConstants.Plane_Ethereal,
            EnvironmentConstants.Plane_Evil,
            EnvironmentConstants.Plane_Fire,
            EnvironmentConstants.Plane_Good,
            EnvironmentConstants.Plane_Lawful,
            EnvironmentConstants.Plane_LawfulEvil,
            EnvironmentConstants.Plane_LawfulGood,
            EnvironmentConstants.Plane_Limbo,
            EnvironmentConstants.Plane_NeutralEvil,
            EnvironmentConstants.Plane_PositiveEnergy,
            EnvironmentConstants.Plane_Shadow,
            EnvironmentConstants.Plane_Water)]
        public void EnvironmentCreatures(string environment, params string[] creatures)
        {
            base.DistinctCollection(environment, creatures);
        }

        [Test]
        public void AnyCreatures()
        {
            var creatures = new[]
            {
                CreatureConstants.Allip,
                CreatureConstants.AnimatedObject,
                CreatureConstants.Mummy,
                CreatureConstants.Lich,
                CreatureConstants.Ghost,
                CreatureConstants.Vampire,
                CreatureConstants.Devourer,
                CreatureConstants.Doppelganger,
                CreatureConstants.Skeleton,
                CreatureConstants.Gargoyle,
                CreatureConstants.Ghoul,
                CreatureConstants.Golem,
                CreatureConstants.Homunculus,
                CreatureConstants.Mohrg,
                CreatureConstants.Shadow,
                CreatureConstants.ShieldGuardian,
                CreatureConstants.Tarrasque,
                CreatureConstants.Wight,
                CreatureConstants.Wraith,
                CreatureConstants.Zombie_Human,
            };

            base.DistinctCollection(EnvironmentConstants.Any, creatures);
        }

        [Test]
        public void LandCreatures()
        {
            var creatures = new[]
            {
                CreatureConstants.Character_Adventurer,
                CreatureConstants.Character_Hunter,
                CreatureConstants.Commoner_Farmer,
                CreatureConstants.Commoner_Herder,
                CreatureConstants.Commoner_Pilgrim,
                CreatureConstants.Doppelganger,
                CreatureConstants.Gargoyle,
                CreatureConstants.NPC_Traveler,
                CreatureConstants.Rat,
                CreatureConstants.Warrior_Bandit,
                CreatureConstants.Character_AnimalTrainer,
                CreatureConstants.Fighter_Captain,
                CreatureConstants.Warrior_Captain,
                CreatureConstants.Paladin_Crusader,
                CreatureConstants.Character_FamousEntertainer,
                CreatureConstants.Character_FamousPriest,
                CreatureConstants.Wizard_FamousResearcher,
                CreatureConstants.Adept_Fortuneteller,
                CreatureConstants.Warrior_Guard,
                CreatureConstants.Character_Hitman,
                CreatureConstants.Bard_Leader,
                CreatureConstants.Cleric_Leader,
                CreatureConstants.Fighter_Leader,
                CreatureConstants.Warrior_Leader,
                CreatureConstants.Character_Merchant,
                CreatureConstants.Character_Minstrel,
                CreatureConstants.Adept_Missionary,
                CreatureConstants.Character_Missionary,
                CreatureConstants.Rogue_Pickpocket,
                CreatureConstants.Character_RetiredAdventurer,
                CreatureConstants.Character_Scholar,
                CreatureConstants.Character_Sellsword,
                CreatureConstants.Character_StarStudent,
                CreatureConstants.Character_Student,
                CreatureConstants.Character_Teacher,
                CreatureConstants.Character_WarHero,
                CreatureConstants.NPC,
                CreatureConstants.Livestock,
                CreatureConstants.Spectre,
                CreatureConstants.Zombie,
            };

            base.DistinctCollection(EnvironmentConstants.Land, creatures);
        }

        [Test]
        public void UndergroundCreatures()
        {
            var encounters = new[]
            {
                CreatureConstants.BlackPudding,
                CreatureConstants.CarrionCrawler,
                CreatureConstants.Centipede_Monstrous,
                CreatureConstants.Centipede_Swarm,
                CreatureConstants.Choker,
                CreatureConstants.Cloaker,
                CreatureConstants.Darkmantle,
                CreatureConstants.Delver,
                CreatureConstants.Derro,
                CreatureConstants.Destrachan,
                CreatureConstants.Drider,
                CreatureConstants.Drow,
                CreatureConstants.Duergar,
                CreatureConstants.Dwarf_Deep,
                CreatureConstants.EtherealFilcher,
                CreatureConstants.Fungus,
                CreatureConstants.GelatinousCube,
                CreatureConstants.GibberingMouther,
                CreatureConstants.Grick,
                CreatureConstants.Grimlock,
                CreatureConstants.Mimic,
                CreatureConstants.MindFlayer,
                CreatureConstants.Minotaur,
                CreatureConstants.Otyugh,
                CreatureConstants.PhantomFungus,
                CreatureConstants.Phasm,
                CreatureConstants.PurpleWorm,
                CreatureConstants.Roper,
                CreatureConstants.RustMonster,
                CreatureConstants.Skum,
                CreatureConstants.Svirfneblin,
                CreatureConstants.Troglodyte,
                CreatureConstants.UmberHulk,
                CreatureConstants.Spectre,
                CreatureConstants.Zombie,
            };

            base.DistinctCollection(EnvironmentConstants.Underground, encounters);
        }

        [Test]
        public void TemperateForestCreatures()
        {
            var creatures = new[]
            {
                CreatureConstants.Aranea,
                CreatureConstants.AssassinVine,
                CreatureConstants.Badger,
                CreatureConstants.Bear_Black,
                CreatureConstants.Boar,
                CreatureConstants.Centaur,
                CreatureConstants.Dragon_Green,
                CreatureConstants.Dryad,
                CreatureConstants.Elf_High,
                CreatureConstants.Elf_Half,
                CreatureConstants.Elf_Wood,
                CreatureConstants.Gnome_Forest,
                CreatureConstants.Grig,
                CreatureConstants.Halfling_Tallfellow,
                CreatureConstants.Hawk,
                CreatureConstants.Kobold,
                CreatureConstants.Zombie_Kobold,
                CreatureConstants.Krenshar,
                CreatureConstants.Nymph,
                CreatureConstants.Owl,
                CreatureConstants.Owlbear,
                CreatureConstants.Skeleton_Owlbear,
                CreatureConstants.Pegasus,
                CreatureConstants.Pixie,
                CreatureConstants.PrayingMantis_Giant,
                CreatureConstants.Pseudodragon,
                CreatureConstants.Raven,
                CreatureConstants.RazorBoar,
                CreatureConstants.Satyr,
                CreatureConstants.Spider_Monstrous,
                CreatureConstants.SpiderEater,
                CreatureConstants.StagBeetle_Giant,
                CreatureConstants.Tendriculos,
                CreatureConstants.Treant,
                CreatureConstants.Unicorn,
                CreatureConstants.Wasp_Giant,
                CreatureConstants.Wolf,
                CreatureConstants.Skeleton_Wolf,
            };

            base.DistinctCollection(EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest, creatures);
        }

        [Test]
        public void TemperateHillsCreatures()
        {
            var creatures = new[]
            {
                CreatureConstants.Athach,
                CreatureConstants.Bulette,
                CreatureConstants.Chimera,
                CreatureConstants.Skeleton_Chimera,
                CreatureConstants.DisplacerBeast,
                CreatureConstants.Dragon_Bronze,
                CreatureConstants.Giant_Hill,
                CreatureConstants.Wereboar_HillGiantDire,
                CreatureConstants.Gnome_Rock,
                CreatureConstants.Griffon,
                CreatureConstants.Hippogriff,
                CreatureConstants.Naga_Dark,
                CreatureConstants.Ogre,
                CreatureConstants.Zombie_Ogre,
                CreatureConstants.Orc,
                CreatureConstants.Orc_Half,
                CreatureConstants.Weasel,
            };

            base.DistinctCollection(EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills, creatures);
        }

        [Test]
        public void TemperateMarshCreatures()
        {
            var creatures = new[]
            {
                CreatureConstants.Chuul,
                CreatureConstants.GrayRender,
                CreatureConstants.Zombie_GrayRender,
                CreatureConstants.GreenHag,
                CreatureConstants.Harpy,
                CreatureConstants.Hydra,
                CreatureConstants.Lizardfolk,
                CreatureConstants.Medusa,
                CreatureConstants.Naga_Spirit,
                CreatureConstants.Ooze_OchreJelly,
                CreatureConstants.ShamblingMound,
                CreatureConstants.Snake_Viper,
                CreatureConstants.Toad,
                CreatureConstants.WillOWisp,
            };

            base.DistinctCollection(EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh, creatures);
        }

        [Test]
        public void TemperateMountainCreatures()
        {
            var creatures = new[]
            {
                CreatureConstants.Bugbear,
                CreatureConstants.Zombie_Bugbear,
                CreatureConstants.Dragon_Silver,
                CreatureConstants.Dwarf_Hill,
                CreatureConstants.Dwarf_Mountain,
                CreatureConstants.Eagle,
                CreatureConstants.Elf_Gray,
                CreatureConstants.Giant_Cloud,
                CreatureConstants.Skeleton_Giant_Cloud,
                CreatureConstants.Giant_Stone,
                CreatureConstants.RazorBoar,
                CreatureConstants.Yrthak,
            };

            base.DistinctCollection(EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain, creatures);
        }

        [Test]
        public void TemperatePlainsCreatures()
        {
            var creatures = new[]
            {
                CreatureConstants.Aasimar,
                CreatureConstants.Ant_Giant,
                CreatureConstants.Bee_Giant,
                CreatureConstants.Bison,
                CreatureConstants.BlinkDog,
                CreatureConstants.Cat,
                CreatureConstants.Cockatrice,
                CreatureConstants.Dog,
                CreatureConstants.Goblin,
                CreatureConstants.Gorgon,
                CreatureConstants.Horse,
                CreatureConstants.Locust,
                CreatureConstants.Naga_Guardian,
                CreatureConstants.Pony,
                CreatureConstants.Tiefling,
                CreatureConstants.Triceratops,
                CreatureConstants.Worg,
                CreatureConstants.Orc_Half,
                CreatureConstants.Skeleton_Human,
            };

            base.DistinctCollection(EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains, creatures);
        }

        [Test]
        public void WarmDesertCreatures()
        {
            var creatures = new[]
            {
                CreatureConstants.Androsphinx,
                CreatureConstants.Basilisk,
                CreatureConstants.Camel,
                CreatureConstants.Criosphinx,
                CreatureConstants.Dragon_Brass,
                CreatureConstants.Gynosphinx,
                CreatureConstants.Hieracosphinx,
                CreatureConstants.Scorpion_Monstrous,
                CreatureConstants.Scorpionfolk,
                CreatureConstants.Hyena,
                CreatureConstants.Janni,
            };

            base.DistinctCollection(EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert, creatures);
        }

        [Test]
        public void WarmForestCreatures()
        {
            var creatures = new[]
            {
                CreatureConstants.Ape,
                CreatureConstants.BombardierBeetle_Giant,
                CreatureConstants.Couatl,
                CreatureConstants.Deinonychus,
                CreatureConstants.Digester,
                CreatureConstants.Elf_Wild,
                CreatureConstants.Ettercap,
                CreatureConstants.Girallon,
                CreatureConstants.Leopard,
                CreatureConstants.Lizard,
                CreatureConstants.Megaraptor,
                CreatureConstants.Skeleton_Megaraptor,
                CreatureConstants.Monkey,
                CreatureConstants.RazorBoar,
                CreatureConstants.Snake_Constrictor,
                CreatureConstants.Spider_Swarm,
                CreatureConstants.Tiger,
                CreatureConstants.YuanTi,
            };

            base.DistinctCollection(EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest, creatures);
        }

        [Test]
        public void WarmHillsCreatures()
        {
            var creatures = new[]
            {
                CreatureConstants.Behir,
                CreatureConstants.Dragon_Copper,
                CreatureConstants.Halfling_Deep,
                CreatureConstants.Hobgoblin,
                CreatureConstants.PhaseSpider,
                CreatureConstants.Scorpionfolk,
                CreatureConstants.Wyvern,
                CreatureConstants.Zombie_Wyvern,
            };

            base.DistinctCollection(EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills, creatures);
        }

        [Test]
        public void WarmMarshCreatures()
        {
            var creatures = new[]
            {
                CreatureConstants.Crocodile,
                CreatureConstants.Dragon_Black,
                CreatureConstants.Manticore,
                CreatureConstants.Pyrohydra,
                CreatureConstants.Rakshasa,
                CreatureConstants.ShockerLizard,
                CreatureConstants.Stirge,
            };

            base.DistinctCollection(EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh, creatures);
        }

        [Test]
        public void WarmMountainCreatures()
        {
            var creatures = new[]
            {
                CreatureConstants.Dragon_Red,
                CreatureConstants.Skeleton_Dragon_Red_YoungAdult,
                CreatureConstants.Giant_Fire,
                CreatureConstants.Giant_Storm,
                CreatureConstants.Roc,
                CreatureConstants.RazorBoar,
            };

            base.DistinctCollection(EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain, creatures);
        }

        [Test]
        public void WarmPlainsCreatures()
        {
            var creatures = new[]
            {
                CreatureConstants.Ankheg,
                CreatureConstants.Baboon,
                CreatureConstants.Cheetah,
                CreatureConstants.Dragon_Gold,
                CreatureConstants.Elephant,
                CreatureConstants.FireBeetle_Giant,
                CreatureConstants.Gnoll,
                CreatureConstants.Halfling_Lightfoot,
                CreatureConstants.Lion,
                CreatureConstants.Rhinoceras,
                CreatureConstants.Scorpionfolk,
                CreatureConstants.Tyrannosaurus,
                CreatureConstants.Mule,
            };

            base.DistinctCollection(EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains, creatures);
        }

        [TestCase(CreatureConstants.Aboleth, EnvironmentConstants.Underground + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Aboleth_Mage, EnvironmentConstants.Underground + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Achaierai, EnvironmentConstants.Plane_Lawful)]
        [TestCase(CreatureConstants.Allip, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.AstralDeva, EnvironmentConstants.Plane_Good)]
        [TestCase(CreatureConstants.Planetar, EnvironmentConstants.Plane_Good)]
        [TestCase(CreatureConstants.Solar, EnvironmentConstants.Plane_Good)]
        [TestCase(CreatureConstants.AnimatedObject_Colossal, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.AnimatedObject_Gargantuan, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.AnimatedObject_Huge, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.AnimatedObject_Large, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.AnimatedObject_Medium, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.AnimatedObject_Small, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.AnimatedObject_Tiny, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Ankheg, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Aranea, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.LanternArchon, EnvironmentConstants.Plane_LawfulGood)]
        [TestCase(CreatureConstants.HoundArchon, EnvironmentConstants.Plane_LawfulGood)]
        [TestCase(CreatureConstants.HoundArchon_Hero, EnvironmentConstants.Plane_LawfulGood)]
        [TestCase(CreatureConstants.TrumpetArchon, EnvironmentConstants.Plane_LawfulGood)]
        [TestCase(CreatureConstants.Arrowhawk_Adult, EnvironmentConstants.Plane_Air)]
        [TestCase(CreatureConstants.Arrowhawk_Elder, EnvironmentConstants.Plane_Air)]
        [TestCase(CreatureConstants.Arrowhawk_Juvenile, EnvironmentConstants.Plane_Air)]
        [TestCase(CreatureConstants.AssassinVine, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Athach, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Avoral, EnvironmentConstants.Plane_Good)]
        [TestCase(CreatureConstants.Azer, EnvironmentConstants.Plane_Fire)]
        [TestCase(CreatureConstants.Barghest, EnvironmentConstants.Plane_Evil)]
        [TestCase(CreatureConstants.Barghest_Greater, EnvironmentConstants.Plane_Evil)]
        [TestCase(CreatureConstants.Basilisk, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Basilisk_AbyssalGreater, EnvironmentConstants.Plane_ChaoticEvil)]
        [TestCase(CreatureConstants.Behir, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Belker, EnvironmentConstants.Plane_Air)]
        [TestCase(CreatureConstants.BlinkDog, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Bodak, EnvironmentConstants.Plane_ChaoticEvil)]
        [TestCase(CreatureConstants.Bralani, EnvironmentConstants.Plane_ChaoticGood)]
        [TestCase(CreatureConstants.Bugbear, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Bugbear_Leader, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Bugbear_Noncombatant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Bugbear_Sergeant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Bulette, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Badger_Celestial, EnvironmentConstants.Plane_Good)]
        [TestCase(CreatureConstants.Dog_Celestial, EnvironmentConstants.Plane_Good)]
        [TestCase(CreatureConstants.FireBeetle_Giant_Celestial, EnvironmentConstants.Plane_Good)]
        [TestCase(CreatureConstants.Monkey_Celestial, EnvironmentConstants.Plane_Good)]
        [TestCase(CreatureConstants.Owl_Celestial, EnvironmentConstants.Plane_Good)]
        [TestCase(CreatureConstants.Porpoise_Celestial, EnvironmentConstants.Plane_Good)]
        [TestCase(CreatureConstants.Centaur, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Centaur_Leader_2ndTo5th, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Centaur_Leader_5thTo9th, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Centaur_Lieutenant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Centaur_Noncombatant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Centaur_Sergeant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.ChaosBeast, EnvironmentConstants.Plane_Limbo)]
        [TestCase(CreatureConstants.Chimera, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Choker, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Chuul, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Cloaker, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Cockatrice, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Couatl, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Darkmantle, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Delver, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Babau, EnvironmentConstants.Plane_ChaoticEvil)]
        [TestCase(CreatureConstants.Balor, EnvironmentConstants.Plane_ChaoticEvil)]
        [TestCase(CreatureConstants.Bebilith, EnvironmentConstants.Plane_ChaoticEvil)]
        [TestCase(CreatureConstants.Dretch, EnvironmentConstants.Plane_ChaoticEvil)]
        [TestCase(CreatureConstants.Glabrezu, EnvironmentConstants.Plane_ChaoticEvil)]
        [TestCase(CreatureConstants.Hezrou, EnvironmentConstants.Plane_ChaoticEvil)]
        [TestCase(CreatureConstants.Marilith, EnvironmentConstants.Plane_ChaoticEvil)]
        [TestCase(CreatureConstants.Nalfeshnee, EnvironmentConstants.Plane_ChaoticEvil)]
        [TestCase(CreatureConstants.Quasit, EnvironmentConstants.Plane_ChaoticEvil)]
        [TestCase(CreatureConstants.Retriever, EnvironmentConstants.Plane_ChaoticEvil)]
        [TestCase(CreatureConstants.Succubus, EnvironmentConstants.Plane_ChaoticEvil)]
        [TestCase(CreatureConstants.Vrock, EnvironmentConstants.Plane_ChaoticEvil)]
        [TestCase(CreatureConstants.Derro, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Derro_Noncombatant, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Derro_Sorcerer_3rd, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Derro_Sorcerer_5thTo8th, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Destrachan, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.BarbedDevil_Hamatula, EnvironmentConstants.Plane_LawfulEvil)]
        [TestCase(CreatureConstants.BeardedDevil_Barbazu, EnvironmentConstants.Plane_LawfulEvil)]
        [TestCase(CreatureConstants.BoneDevil_Osyluth, EnvironmentConstants.Plane_LawfulEvil)]
        [TestCase(CreatureConstants.ChainDevil_Kyton, EnvironmentConstants.Plane_LawfulEvil)]
        [TestCase(CreatureConstants.Erinyes, EnvironmentConstants.Plane_LawfulEvil)]
        [TestCase(CreatureConstants.Hellcat_Bezekira, EnvironmentConstants.Plane_LawfulEvil)]
        [TestCase(CreatureConstants.HornedDevil_Cornugon, EnvironmentConstants.Plane_LawfulEvil)]
        [TestCase(CreatureConstants.IceDevil_Gelugon, EnvironmentConstants.Plane_LawfulEvil)]
        [TestCase(CreatureConstants.Imp, EnvironmentConstants.Plane_LawfulEvil)]
        [TestCase(CreatureConstants.Lemure, EnvironmentConstants.Plane_LawfulEvil)]
        [TestCase(CreatureConstants.PitFiend, EnvironmentConstants.Plane_LawfulEvil)]
        [TestCase(CreatureConstants.Devourer, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Digester, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Deinonychus, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elasmosaurus, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Megaraptor, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Triceratops, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Tyrannosaurus, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Ape_Dire, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Badger_Dire, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Bat_Dire, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Bear_Dire, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Boar_Dire, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Lion_Dire, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Rat_Dire, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Rat_Dire_Fiendish, EnvironmentConstants.Plane_Evil)]
        [TestCase(CreatureConstants.Shark_Dire, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Tiger_Dire, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Weasel_Dire, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Wolf_Dire, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Wolverine_Dire, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Doppelganger, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Dragon_Black_Adult, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Dragon_Black_Ancient, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Dragon_Black_GreatWyrm, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Dragon_Black_Juvenile, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Dragon_Black_MatureAdult, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Dragon_Black_Old, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Dragon_Black_VeryOld, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Dragon_Black_VeryYoung, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Dragon_Black_Wyrm, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Dragon_Black_Wyrmling, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Dragon_Black_Young, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Dragon_Black_YoungAdult, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Dragon_Blue_Adult, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Blue_Ancient, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Blue_GreatWyrm, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Blue_Juvenile, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Blue_MatureAdult, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Blue_Old, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Blue_VeryOld, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Blue_VeryYoung, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Blue_Wyrm, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Blue_Wyrmling, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Blue_Young, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Blue_YoungAdult, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Brass_Adult, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Brass_Ancient, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Brass_GreatWyrm, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Brass_Juvenile, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Brass_MatureAdult, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Brass_Old, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Brass_VeryOld, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Brass_VeryYoung, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Brass_Wyrm, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Brass_Wyrmling, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Brass_Young, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Brass_YoungAdult, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Dragon_Bronze_Adult, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Bronze_Ancient, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Bronze_GreatWyrm, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Bronze_Juvenile, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Bronze_MatureAdult, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Bronze_Old, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Bronze_VeryOld, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Bronze_VeryYoung, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Bronze_Wyrm, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Bronze_Wyrmling, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Bronze_Young, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Bronze_YoungAdult, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Copper_Adult, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Copper_Ancient, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Copper_GreatWyrm, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Copper_Juvenile, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Copper_MatureAdult, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Copper_Old, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Copper_VeryOld, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Copper_VeryYoung, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Copper_Wyrm, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Copper_Wyrmling, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Copper_Young, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Copper_YoungAdult, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Dragon_Gold_Adult, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Dragon_Gold_Ancient, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Dragon_Gold_GreatWyrm, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Dragon_Gold_Juvenile, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Dragon_Gold_MatureAdult, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Dragon_Gold_Old, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Dragon_Gold_VeryOld, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Dragon_Gold_VeryYoung, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Dragon_Gold_Wyrm, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Dragon_Gold_Wyrmling, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Dragon_Gold_Young, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Dragon_Gold_YoungAdult, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Dragon_Green_Adult, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Dragon_Green_Ancient, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Dragon_Green_GreatWyrm, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Dragon_Green_Juvenile, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Dragon_Green_MatureAdult, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Dragon_Green_Old, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Dragon_Green_VeryOld, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Dragon_Green_VeryYoung, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Dragon_Green_Wyrm, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Dragon_Green_Wyrmling, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Dragon_Green_Young, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Dragon_Green_YoungAdult, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Dragon_Red_Adult, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_Red_Ancient, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_Red_GreatWyrm, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_Red_Juvenile, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_Red_MatureAdult, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_Red_Old, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_Red_VeryOld, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_Red_VeryYoung, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_Red_Wyrm, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_Red_Wyrmling, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_Red_Young, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_Red_YoungAdult, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_Silver_Adult, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_Silver_Ancient, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_Silver_GreatWyrm, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_Silver_Juvenile, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_Silver_MatureAdult, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_Silver_Old, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_Silver_VeryOld, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_Silver_VeryYoung, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_Silver_Wyrm, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_Silver_Wyrmling, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_Silver_Young, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_Silver_YoungAdult, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_White_Adult, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_White_Ancient, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_White_GreatWyrm, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_White_Juvenile, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_White_MatureAdult, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_White_Old, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_White_VeryOld, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_White_VeryYoung, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_White_Wyrm, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_White_Wyrmling, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_White_Young, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dragon_White_YoungAdult, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.DragonTurtle, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Dragonne, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Drider, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Dryad, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Dwarf_Hill_Captain, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dwarf_Hill_Leader, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dwarf_Hill_Lieutenant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dwarf_Hill_Noncombatant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dwarf_Hill_Sergeant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dwarf_Hill_Warrior, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dwarf_Mountain_Captain, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dwarf_Mountain_Leader, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dwarf_Mountain_Lieutenant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dwarf_Mountain_Noncombatant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dwarf_Mountain_Sergeant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dwarf_Mountain_Warrior, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Dwarf_Deep_Captain, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Dwarf_Deep_Leader, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Dwarf_Deep_Lieutenant, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Dwarf_Deep_Noncombatant, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Dwarf_Deep_Sergeant, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Dwarf_Deep_Warrior, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Duergar_Captain, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Duergar_Leader, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Duergar_Lieutenant, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Duergar_Noncombatant, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Duergar_Sergeant, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Duergar_Warrior, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Eagle_Giant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Elemental_Air_Elder, EnvironmentConstants.Plane_Air)]
        [TestCase(CreatureConstants.Elemental_Air_Greater, EnvironmentConstants.Plane_Air)]
        [TestCase(CreatureConstants.Elemental_Air_Huge, EnvironmentConstants.Plane_Air)]
        [TestCase(CreatureConstants.Elemental_Air_Large, EnvironmentConstants.Plane_Air)]
        [TestCase(CreatureConstants.Elemental_Air_Medium, EnvironmentConstants.Plane_Air)]
        [TestCase(CreatureConstants.Elemental_Air_Small, EnvironmentConstants.Plane_Air)]
        [TestCase(CreatureConstants.Elemental_Earth_Elder, EnvironmentConstants.Plane_Earth)]
        [TestCase(CreatureConstants.Elemental_Earth_Greater, EnvironmentConstants.Plane_Earth)]
        [TestCase(CreatureConstants.Elemental_Earth_Huge, EnvironmentConstants.Plane_Earth)]
        [TestCase(CreatureConstants.Elemental_Earth_Large, EnvironmentConstants.Plane_Earth)]
        [TestCase(CreatureConstants.Elemental_Earth_Medium, EnvironmentConstants.Plane_Earth)]
        [TestCase(CreatureConstants.Elemental_Earth_Small, EnvironmentConstants.Plane_Earth)]
        [TestCase(CreatureConstants.Elemental_Fire_Elder, EnvironmentConstants.Plane_Fire)]
        [TestCase(CreatureConstants.Elemental_Fire_Greater, EnvironmentConstants.Plane_Fire)]
        [TestCase(CreatureConstants.Elemental_Fire_Huge, EnvironmentConstants.Plane_Fire)]
        [TestCase(CreatureConstants.Elemental_Fire_Large, EnvironmentConstants.Plane_Fire)]
        [TestCase(CreatureConstants.Elemental_Fire_Medium, EnvironmentConstants.Plane_Fire)]
        [TestCase(CreatureConstants.Elemental_Fire_Small, EnvironmentConstants.Plane_Fire)]
        [TestCase(CreatureConstants.Elemental_Water_Elder, EnvironmentConstants.Plane_Water)]
        [TestCase(CreatureConstants.Elemental_Water_Greater, EnvironmentConstants.Plane_Water)]
        [TestCase(CreatureConstants.Elemental_Water_Huge, EnvironmentConstants.Plane_Water)]
        [TestCase(CreatureConstants.Elemental_Water_Large, EnvironmentConstants.Plane_Water)]
        [TestCase(CreatureConstants.Elemental_Water_Medium, EnvironmentConstants.Plane_Water)]
        [TestCase(CreatureConstants.Elemental_Water_Small, EnvironmentConstants.Plane_Water)]
        [TestCase(CreatureConstants.Elf_High_Captain, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elf_High_Leader, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elf_High_Lieutenant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elf_High_Noncombatant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elf_High_Sergeant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elf_High_Warrior, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elf_Half_Captain, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elf_Half_Leader, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elf_Half_Lieutenant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elf_Half_Noncombatant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elf_Half_Sergeant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elf_Half_Warrior, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elf_Aquatic_Captain, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Elf_Aquatic_Leader, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Elf_Aquatic_Lieutenant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Elf_Aquatic_Noncombatant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Elf_Aquatic_Sergeant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Elf_Aquatic_Warrior, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Elf_Gray_Captain, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Elf_Gray_Leader, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Elf_Gray_Lieutenant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Elf_Gray_Noncombatant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Elf_Gray_Sergeant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Elf_Gray_Warrior, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Elf_Wild_Captain, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elf_Wild_Leader, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elf_Wild_Lieutenant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elf_Wild_Noncombatant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elf_Wild_Sergeant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elf_Wild_Warrior, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elf_Wood_Captain, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elf_Wood_Leader, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elf_Wood_Lieutenant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elf_Wood_Noncombatant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elf_Wood_Sergeant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Elf_Wood_Warrior, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Drow_Captain, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Drow_Leader, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Drow_Lieutenant, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Drow_Noncombatant, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Drow_Sergeant, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Drow_Warrior, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.EtherealFilcher, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.EtherealMarauder, EnvironmentConstants.Plane_Ethereal)]
        [TestCase(CreatureConstants.Ettercap, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Ettin, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Centipede_Monstrous_Fiendish_Colossal, EnvironmentConstants.Plane_Evil)]
        [TestCase(CreatureConstants.Centipede_Monstrous_Fiendish_Gargantuan, EnvironmentConstants.Plane_Evil)]
        [TestCase(CreatureConstants.Centipede_Monstrous_Fiendish_Huge, EnvironmentConstants.Plane_Evil)]
        [TestCase(CreatureConstants.Centipede_Monstrous_Fiendish_Large, EnvironmentConstants.Plane_Evil)]
        [TestCase(CreatureConstants.Centipede_Monstrous_Fiendish_Medium, EnvironmentConstants.Plane_Evil)]
        [TestCase(CreatureConstants.Raven_Fiendish, EnvironmentConstants.Plane_Evil)]
        [TestCase(CreatureConstants.FormianMyrmarch, EnvironmentConstants.Plane_Lawful)]
        [TestCase(CreatureConstants.FormianQueen, EnvironmentConstants.Plane_Lawful)]
        [TestCase(CreatureConstants.FormianTaskmaster, EnvironmentConstants.Plane_Lawful)]
        [TestCase(CreatureConstants.FormianWarrior, EnvironmentConstants.Plane_Lawful)]
        [TestCase(CreatureConstants.FormianWorker, EnvironmentConstants.Plane_Lawful)]
        [TestCase(CreatureConstants.FrostWorm, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Shrieker, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.VioletFungus, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Gargoyle, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Gargoyle_Kapoacinth, EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Djinni, EnvironmentConstants.Plane_Air)]
        [TestCase(CreatureConstants.Djinni_Noble, EnvironmentConstants.Plane_Air)]
        [TestCase(CreatureConstants.Efreeti, EnvironmentConstants.Plane_Fire)]
        [TestCase(CreatureConstants.Janni, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Ghaele, EnvironmentConstants.Plane_ChaoticGood)]
        [TestCase(CreatureConstants.Ghost_Level1, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Ghost_Level10, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Ghost_Level11, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Ghost_Level12, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Ghost_Level13, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Ghost_Level14, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Ghost_Level15, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Ghost_Level16, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Ghost_Level17, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Ghost_Level18, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Ghost_Level19, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Ghost_Level2, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Ghost_Level20, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Ghost_Level3, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Ghost_Level4, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Ghost_Level5, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Ghost_Level6, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Ghost_Level7, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Ghost_Level8, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Ghost_Level9, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Ghoul, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Ghoul_Ghast, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Ghoul_Lacedon, EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Giant_Cloud, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Cloud_Leader, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Cloud_Noncombatant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Fire, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Fire_Adept_1stTo2nd, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Fire_Adept_3rdTo5th, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Fire_Adept_6thTo7th, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Fire_Cleric_1stTo2nd, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Fire_Leader_6thTo7th, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Fire_Noncombatant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Fire_Sorcerer_3rdTo5th, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Frost, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Frost_Adept_1stTo2nd, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Frost_Adept_3rdTo5th, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Frost_Adept_6thTo7th, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Frost_Cleric_1stTo2nd, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Frost_Jarl, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Frost_Leader_6thTo7th, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Frost_Noncombatant, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Frost_Sorcerer_3rdTo5th, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Hill, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Giant_Hill_Noncombatant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Giant_Stone, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Stone_Elder, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Stone_Noncombatant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Storm, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Storm_Leader, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Giant_Storm_Noncombatant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.GibberingMouther, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Girallon, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Gnoll, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Gnoll_Leader_4thTo6th, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Gnoll_Leader_6thTo8th, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Gnoll_Lieutenant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Gnoll_Noncombatant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Gnoll_Sergeant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Gnome_Rock_Captain, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Gnome_Rock_Leader, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Gnome_Rock_Lieutenant_3rd, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Gnome_Rock_Lieutenant_5th, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Gnome_Rock_Sergeant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Gnome_Rock_Warrior, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Gnome_Forest_Captain, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Gnome_Forest_Leader, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Gnome_Forest_Lieutenant_3rd, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Gnome_Forest_Lieutenant_5th, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Gnome_Forest_Sergeant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Gnome_Forest_Warrior, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Svirfneblin_Captain, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Svirfneblin_Leader, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Svirfneblin_Lieutenant_3rd, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Svirfneblin_Lieutenant_5th, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Svirfneblin_Sergeant, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Svirfneblin_Warrior, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Goblin_Leader_4thTo6th, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Goblin_Leader_6thTo8th, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Goblin_Lieutenant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Goblin_Noncombatant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Goblin_Sergeant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Goblin_Warrior, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Golem_Clay, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Golem_Flesh, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Golem_Iron, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Golem_Stone, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Golem_Stone_Greater, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Gorgon, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.GrayRender, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Grick, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Griffon, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Grimlock, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Grimlock_Leader, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Character_Adventurer_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Adventurer_Level10, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Adventurer_Level11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Adventurer_Level12, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Adventurer_Level13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Adventurer_Level14, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Adventurer_Level15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Adventurer_Level16, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Adventurer_Level17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Adventurer_Level18, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Adventurer_Level19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Adventurer_Level2, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Adventurer_Level20, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Adventurer_Level3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Adventurer_Level4, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Adventurer_Level5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Adventurer_Level6, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Adventurer_Level7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Adventurer_Level8, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Adventurer_Level9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level10, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level12, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level14, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level16, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level18, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level2, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level20, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level4, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level6, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level8, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Doctor_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Doctor_Level10, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Doctor_Level11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Doctor_Level12, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Doctor_Level13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Doctor_Level14, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Doctor_Level15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Doctor_Level16, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Doctor_Level17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Doctor_Level18, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Doctor_Level19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Doctor_Level2, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Doctor_Level20, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Doctor_Level3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Doctor_Level4, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Doctor_Level5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Doctor_Level6, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Doctor_Level7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Doctor_Level8, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Doctor_Level9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_FamousEntertainer_Level11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_FamousEntertainer_Level12, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_FamousEntertainer_Level13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_FamousEntertainer_Level14, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_FamousEntertainer_Level15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_FamousEntertainer_Level16, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_FamousEntertainer_Level17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_FamousEntertainer_Level18, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_FamousEntertainer_Level19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_FamousEntertainer_Level20, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_FamousPriest_Level11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_FamousPriest_Level12, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_FamousPriest_Level13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_FamousPriest_Level14, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_FamousPriest_Level15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_FamousPriest_Level16, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_FamousPriest_Level17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_FamousPriest_Level18, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_FamousPriest_Level19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_FamousPriest_Level20, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hitman_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hitman_Level10, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hitman_Level11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hitman_Level12, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hitman_Level13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hitman_Level14, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hitman_Level15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hitman_Level16, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hitman_Level17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hitman_Level18, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hitman_Level19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hitman_Level2, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hitman_Level20, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hitman_Level3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hitman_Level4, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hitman_Level5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hitman_Level6, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hitman_Level7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hitman_Level8, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hitman_Level9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hunter_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hunter_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hunter_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hunter_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hunter_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hunter_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hunter_Level20, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hunter_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hunter_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hunter_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Hunter_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Merchant_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Merchant_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Merchant_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Merchant_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Merchant_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Merchant_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Merchant_Level20, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Merchant_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Merchant_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Merchant_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Merchant_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Minstrel_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Minstrel_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Minstrel_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Minstrel_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Minstrel_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Minstrel_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Minstrel_Level20, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Minstrel_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Minstrel_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Minstrel_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Minstrel_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Missionary_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Missionary_Level10, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Missionary_Level11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Missionary_Level12, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Missionary_Level13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Missionary_Level14, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Missionary_Level15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Missionary_Level16, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Missionary_Level17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Missionary_Level18, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Missionary_Level19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Missionary_Level2, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Missionary_Level20, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Missionary_Level3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Missionary_Level4, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Missionary_Level5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Missionary_Level6, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Missionary_Level7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Missionary_Level8, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Missionary_Level9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_RetiredAdventurer_Level11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_RetiredAdventurer_Level12, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_RetiredAdventurer_Level13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_RetiredAdventurer_Level14, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_RetiredAdventurer_Level15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_RetiredAdventurer_Level16, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_RetiredAdventurer_Level17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_RetiredAdventurer_Level18, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_RetiredAdventurer_Level19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_RetiredAdventurer_Level20, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Scholar_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Scholar_Level10, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Scholar_Level11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Scholar_Level12, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Scholar_Level13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Scholar_Level14, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Scholar_Level15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Scholar_Level16, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Scholar_Level17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Scholar_Level18, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Scholar_Level19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Scholar_Level2, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Scholar_Level20, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Scholar_Level3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Scholar_Level4, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Scholar_Level5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Scholar_Level6, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Scholar_Level7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Scholar_Level8, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Scholar_Level9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Sellsword_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Sellsword_Level10, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Sellsword_Level11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Sellsword_Level12, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Sellsword_Level13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Sellsword_Level14, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Sellsword_Level15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Sellsword_Level16, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Sellsword_Level17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Sellsword_Level18, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Sellsword_Level19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Sellsword_Level2, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Sellsword_Level20, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Sellsword_Level3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Sellsword_Level4, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Sellsword_Level5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Sellsword_Level6, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Sellsword_Level7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Sellsword_Level8, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Sellsword_Level9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StarStudent_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StarStudent_Level10, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StarStudent_Level2, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StarStudent_Level3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StarStudent_Level4, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StarStudent_Level5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StarStudent_Level6, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StarStudent_Level7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StarStudent_Level8, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StarStudent_Level9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StreetPerformer_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StreetPerformer_Level10, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StreetPerformer_Level11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StreetPerformer_Level12, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StreetPerformer_Level13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StreetPerformer_Level14, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StreetPerformer_Level15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StreetPerformer_Level16, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StreetPerformer_Level17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StreetPerformer_Level18, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StreetPerformer_Level19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StreetPerformer_Level2, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StreetPerformer_Level20, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StreetPerformer_Level3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StreetPerformer_Level4, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StreetPerformer_Level5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StreetPerformer_Level6, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StreetPerformer_Level7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StreetPerformer_Level8, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_StreetPerformer_Level9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Student_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Student_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Student_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Student_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Student_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Student_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Student_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Student_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Student_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Student_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Teacher_Level11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Teacher_Level12, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Teacher_Level13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Teacher_Level14, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Teacher_Level15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Teacher_Level16, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Teacher_Level17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Teacher_Level18, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Teacher_Level19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Teacher_Level20, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_WarHero_Level11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_WarHero_Level12, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_WarHero_Level13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_WarHero_Level14, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_WarHero_Level15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_WarHero_Level16, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_WarHero_Level17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_WarHero_Level18, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_WarHero_Level19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_WarHero_Level20, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Wizard_FamousResearcher_Level11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Wizard_FamousResearcher_Level12, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Wizard_FamousResearcher_Level13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Wizard_FamousResearcher_Level14, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Wizard_FamousResearcher_Level15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Wizard_FamousResearcher_Level16, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Wizard_FamousResearcher_Level17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Wizard_FamousResearcher_Level18, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Wizard_FamousResearcher_Level19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Wizard_FamousResearcher_Level20, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Doctor_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Doctor_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Doctor_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Doctor_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Doctor_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Doctor_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Doctor_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Doctor_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Doctor_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Doctor_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Fortuneteller_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Fortuneteller_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Fortuneteller_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Fortuneteller_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Fortuneteller_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Fortuneteller_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Fortuneteller_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Fortuneteller_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Fortuneteller_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Fortuneteller_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Missionary_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Missionary_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Missionary_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Missionary_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Missionary_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Missionary_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Missionary_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Missionary_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Missionary_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_Missionary_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_StreetPerformer_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_StreetPerformer_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_StreetPerformer_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_StreetPerformer_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_StreetPerformer_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_StreetPerformer_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_StreetPerformer_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_StreetPerformer_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_StreetPerformer_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Adept_StreetPerformer_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Businessman_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Businessman_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Businessman_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Businessman_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Businessman_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Businessman_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Businessman_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Businessman_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Businessman_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Businessman_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Gentry_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Gentry_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Gentry_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Gentry_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Gentry_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Gentry_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Gentry_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Gentry_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Gentry_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Gentry_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Politician_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Politician_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Politician_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Politician_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Politician_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Politician_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Politician_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Politician_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Politician_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Aristocrat_Politician_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Bard_Leader_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Bard_Leader_Level10, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Bard_Leader_Level11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Bard_Leader_Level2, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Bard_Leader_Level3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Bard_Leader_Level4, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Bard_Leader_Level5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Bard_Leader_Level6, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Bard_Leader_Level7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Bard_Leader_Level8, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Bard_Leader_Level9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Cleric_Leader_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Cleric_Leader_Level10, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Cleric_Leader_Level11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Cleric_Leader_Level2, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Cleric_Leader_Level3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Cleric_Leader_Level4, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Cleric_Leader_Level5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Cleric_Leader_Level6, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Cleric_Leader_Level7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Cleric_Leader_Level8, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Cleric_Leader_Level9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Beggar_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Beggar_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Beggar_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Beggar_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Beggar_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Beggar_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Beggar_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Beggar_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Beggar_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Beggar_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_ConstructionWorker_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_ConstructionWorker_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_ConstructionWorker_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_ConstructionWorker_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_ConstructionWorker_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_ConstructionWorker_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_ConstructionWorker_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_ConstructionWorker_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_ConstructionWorker_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_ConstructionWorker_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Farmer_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Farmer_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Farmer_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Farmer_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Farmer_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Farmer_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Farmer_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Farmer_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Farmer_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Farmer_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Herder_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Herder_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Herder_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Herder_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Herder_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Herder_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Herder_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Herder_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Herder_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Herder_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Pilgrim_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Pilgrim_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Pilgrim_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Pilgrim_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Pilgrim_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Pilgrim_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Pilgrim_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Pilgrim_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Pilgrim_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Pilgrim_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Protestor_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Protestor_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Protestor_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Protestor_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Protestor_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Protestor_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Protestor_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Protestor_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Protestor_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Protestor_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Servant_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Servant_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Servant_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Servant_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Servant_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Servant_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Servant_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Servant_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Servant_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Commoner_Servant_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Adviser_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Adviser_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Adviser_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Adviser_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Adviser_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Adviser_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Adviser_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Adviser_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Adviser_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Adviser_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Architect_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Architect_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Architect_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Architect_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Architect_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Architect_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Architect_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Architect_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Architect_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Architect_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Artisan_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Artisan_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Artisan_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Artisan_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Artisan_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Artisan_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Artisan_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Artisan_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Artisan_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Expert_Artisan_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Fighter_Captain_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Fighter_Captain_Level10, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Fighter_Captain_Level11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Fighter_Captain_Level2, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Fighter_Captain_Level3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Fighter_Captain_Level4, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Fighter_Captain_Level5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Fighter_Captain_Level6, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Fighter_Captain_Level7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Fighter_Captain_Level8, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Fighter_Captain_Level9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Fighter_Leader_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Fighter_Leader_Level10, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Fighter_Leader_Level11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Fighter_Leader_Level2, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Fighter_Leader_Level3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Fighter_Leader_Level4, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Fighter_Leader_Level5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Fighter_Leader_Level6, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Fighter_Leader_Level7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Fighter_Leader_Level8, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Fighter_Leader_Level9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Livestock_Noncombatant, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.NPC_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.NPC_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.NPC_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.NPC_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.NPC_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.NPC_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.NPC_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.NPC_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.NPC_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.NPC_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.NPC_Traveler_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.NPC_Traveler_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.NPC_Traveler_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.NPC_Traveler_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.NPC_Traveler_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.NPC_Traveler_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.NPC_Traveler_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.NPC_Traveler_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.NPC_Traveler_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.NPC_Traveler_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level10, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level12, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level14, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level16, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level18, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level2, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level20, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level4, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level6, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level8, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level10, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level12, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level14, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level16, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level18, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level2, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level20, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level4, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level6, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level8, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Bandit_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Bandit_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Bandit_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Bandit_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Bandit_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Bandit_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Bandit_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Bandit_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Bandit_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Bandit_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Captain_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Captain_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Captain_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Captain_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Captain_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Captain_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Captain_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Captain_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Captain_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Guard_Level1, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Guard_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Guard_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Guard_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Guard_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Guard_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Guard_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Guard_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Guard_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Guard_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Leader_Level10To11, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Leader_Level12To13, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Leader_Level14To15, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Leader_Level16To17, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Leader_Level18To19, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Leader_Level2To3, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Leader_Level4To5, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Leader_Level6To7, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Warrior_Leader_Level8To9, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Character_Adventurer_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Adventurer_Level10, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Adventurer_Level11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Adventurer_Level12, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Adventurer_Level13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Adventurer_Level14, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Adventurer_Level15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Adventurer_Level16, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Adventurer_Level17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Adventurer_Level18, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Adventurer_Level19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Adventurer_Level2, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Adventurer_Level20, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Adventurer_Level3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Adventurer_Level4, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Adventurer_Level5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Adventurer_Level6, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Adventurer_Level7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Adventurer_Level8, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Adventurer_Level9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level10, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level12, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level14, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level16, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level18, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level2, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level20, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level4, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level6, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level8, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_AnimalTrainer_Level9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_FamousEntertainer_Level11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_FamousEntertainer_Level12, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_FamousEntertainer_Level13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_FamousEntertainer_Level14, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_FamousEntertainer_Level15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_FamousEntertainer_Level16, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_FamousEntertainer_Level17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_FamousEntertainer_Level18, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_FamousEntertainer_Level19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_FamousEntertainer_Level20, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_FamousPriest_Level11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_FamousPriest_Level12, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_FamousPriest_Level13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_FamousPriest_Level14, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_FamousPriest_Level15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_FamousPriest_Level16, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_FamousPriest_Level17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_FamousPriest_Level18, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_FamousPriest_Level19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_FamousPriest_Level20, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hitman_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hitman_Level10, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hitman_Level11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hitman_Level12, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hitman_Level13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hitman_Level14, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hitman_Level15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hitman_Level16, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hitman_Level17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hitman_Level18, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hitman_Level19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hitman_Level2, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hitman_Level20, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hitman_Level3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hitman_Level4, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hitman_Level5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hitman_Level6, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hitman_Level7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hitman_Level8, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hitman_Level9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hunter_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hunter_Level10To11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hunter_Level12To13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hunter_Level14To15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hunter_Level16To17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hunter_Level18To19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hunter_Level20, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hunter_Level2To3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hunter_Level4To5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hunter_Level6To7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Hunter_Level8To9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Merchant_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Merchant_Level10To11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Merchant_Level12To13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Merchant_Level14To15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Merchant_Level16To17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Merchant_Level18To19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Merchant_Level20, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Merchant_Level2To3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Merchant_Level4To5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Merchant_Level6To7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Merchant_Level8To9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Minstrel_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Minstrel_Level10To11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Minstrel_Level12To13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Minstrel_Level14To15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Minstrel_Level16To17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Minstrel_Level18To19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Minstrel_Level20, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Minstrel_Level2To3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Minstrel_Level4To5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Minstrel_Level6To7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Minstrel_Level8To9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Missionary_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Missionary_Level10, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Missionary_Level11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Missionary_Level12, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Missionary_Level13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Missionary_Level14, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Missionary_Level15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Missionary_Level16, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Missionary_Level17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Missionary_Level18, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Missionary_Level19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Missionary_Level2, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Missionary_Level20, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Missionary_Level3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Missionary_Level4, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Missionary_Level5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Missionary_Level6, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Missionary_Level7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Missionary_Level8, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Missionary_Level9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_RetiredAdventurer_Level11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_RetiredAdventurer_Level12, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_RetiredAdventurer_Level13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_RetiredAdventurer_Level14, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_RetiredAdventurer_Level15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_RetiredAdventurer_Level16, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_RetiredAdventurer_Level17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_RetiredAdventurer_Level18, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_RetiredAdventurer_Level19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_RetiredAdventurer_Level20, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Scholar_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Scholar_Level10, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Scholar_Level11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Scholar_Level12, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Scholar_Level13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Scholar_Level14, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Scholar_Level15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Scholar_Level16, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Scholar_Level17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Scholar_Level18, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Scholar_Level19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Scholar_Level2, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Scholar_Level20, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Scholar_Level3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Scholar_Level4, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Scholar_Level5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Scholar_Level6, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Scholar_Level7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Scholar_Level8, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Scholar_Level9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Sellsword_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Sellsword_Level10, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Sellsword_Level11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Sellsword_Level12, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Sellsword_Level13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Sellsword_Level14, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Sellsword_Level15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Sellsword_Level16, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Sellsword_Level17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Sellsword_Level18, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Sellsword_Level19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Sellsword_Level2, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Sellsword_Level20, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Sellsword_Level3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Sellsword_Level4, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Sellsword_Level5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Sellsword_Level6, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Sellsword_Level7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Sellsword_Level8, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Sellsword_Level9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_StarStudent_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_StarStudent_Level10, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_StarStudent_Level2, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_StarStudent_Level3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_StarStudent_Level4, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_StarStudent_Level5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_StarStudent_Level6, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_StarStudent_Level7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_StarStudent_Level8, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_StarStudent_Level9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Student_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Student_Level10To11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Student_Level12To13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Student_Level14To15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Student_Level16To17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Student_Level18To19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Student_Level2To3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Student_Level4To5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Student_Level6To7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Student_Level8To9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Teacher_Level11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Teacher_Level12, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Teacher_Level13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Teacher_Level14, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Teacher_Level15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Teacher_Level16, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Teacher_Level17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Teacher_Level18, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Teacher_Level19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_Teacher_Level20, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_WarHero_Level11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_WarHero_Level12, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_WarHero_Level13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_WarHero_Level14, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_WarHero_Level15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_WarHero_Level16, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_WarHero_Level17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_WarHero_Level18, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_WarHero_Level19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Character_WarHero_Level20, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Wizard_FamousResearcher_Level11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Wizard_FamousResearcher_Level12, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Wizard_FamousResearcher_Level13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Wizard_FamousResearcher_Level14, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Wizard_FamousResearcher_Level15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Wizard_FamousResearcher_Level16, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Wizard_FamousResearcher_Level17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Wizard_FamousResearcher_Level18, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Wizard_FamousResearcher_Level19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Wizard_FamousResearcher_Level20, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Adept_Fortuneteller_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Adept_Fortuneteller_Level10To11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Adept_Fortuneteller_Level12To13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Adept_Fortuneteller_Level14To15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Adept_Fortuneteller_Level16To17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Adept_Fortuneteller_Level18To19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Adept_Fortuneteller_Level2To3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Adept_Fortuneteller_Level4To5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Adept_Fortuneteller_Level6To7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Adept_Fortuneteller_Level8To9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Adept_Missionary_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Adept_Missionary_Level10To11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Adept_Missionary_Level12To13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Adept_Missionary_Level14To15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Adept_Missionary_Level16To17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Adept_Missionary_Level18To19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Adept_Missionary_Level2To3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Adept_Missionary_Level4To5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Adept_Missionary_Level6To7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Adept_Missionary_Level8To9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Bard_Leader_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Bard_Leader_Level10, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Bard_Leader_Level11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Bard_Leader_Level2, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Bard_Leader_Level3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Bard_Leader_Level4, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Bard_Leader_Level5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Bard_Leader_Level6, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Bard_Leader_Level7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Bard_Leader_Level8, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Bard_Leader_Level9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Cleric_Leader_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Cleric_Leader_Level10, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Cleric_Leader_Level11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Cleric_Leader_Level2, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Cleric_Leader_Level3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Cleric_Leader_Level4, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Cleric_Leader_Level5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Cleric_Leader_Level6, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Cleric_Leader_Level7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Cleric_Leader_Level8, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Cleric_Leader_Level9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Farmer_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Farmer_Level10To11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Farmer_Level12To13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Farmer_Level14To15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Farmer_Level16To17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Farmer_Level18To19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Farmer_Level2To3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Farmer_Level4To5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Farmer_Level6To7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Farmer_Level8To9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Herder_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Herder_Level10To11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Herder_Level12To13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Herder_Level14To15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Herder_Level16To17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Herder_Level18To19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Herder_Level2To3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Herder_Level4To5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Herder_Level6To7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Herder_Level8To9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Pilgrim_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Pilgrim_Level10To11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Pilgrim_Level12To13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Pilgrim_Level14To15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Pilgrim_Level16To17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Pilgrim_Level18To19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Pilgrim_Level2To3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Pilgrim_Level4To5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Pilgrim_Level6To7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Commoner_Pilgrim_Level8To9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Fighter_Captain_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Fighter_Captain_Level10, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Fighter_Captain_Level11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Fighter_Captain_Level2, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Fighter_Captain_Level3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Fighter_Captain_Level4, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Fighter_Captain_Level5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Fighter_Captain_Level6, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Fighter_Captain_Level7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Fighter_Captain_Level8, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Fighter_Captain_Level9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Fighter_Leader_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Fighter_Leader_Level10, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Fighter_Leader_Level11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Fighter_Leader_Level2, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Fighter_Leader_Level3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Fighter_Leader_Level4, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Fighter_Leader_Level5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Fighter_Leader_Level6, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Fighter_Leader_Level7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Fighter_Leader_Level8, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Fighter_Leader_Level9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Livestock_Noncombatant, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.NPC_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.NPC_Level10To11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.NPC_Level12To13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.NPC_Level14To15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.NPC_Level16To17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.NPC_Level18To19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.NPC_Level2To3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.NPC_Level4To5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.NPC_Level6To7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.NPC_Level8To9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.NPC_Traveler_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.NPC_Traveler_Level10To11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.NPC_Traveler_Level12To13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.NPC_Traveler_Level14To15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.NPC_Traveler_Level16To17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.NPC_Traveler_Level18To19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.NPC_Traveler_Level2To3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.NPC_Traveler_Level4To5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.NPC_Traveler_Level6To7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.NPC_Traveler_Level8To9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level10, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level12, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level14, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level16, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level18, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level2, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level20, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level4, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level6, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level8, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Paladin_Crusader_Level9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level10, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level12, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level14, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level16, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level18, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level2, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level20, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level4, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level6, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level8, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Rogue_Pickpocket_Level9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Bandit_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Bandit_Level10To11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Bandit_Level12To13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Bandit_Level14To15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Bandit_Level16To17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Bandit_Level18To19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Bandit_Level2To3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Bandit_Level4To5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Bandit_Level6To7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Bandit_Level8To9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Captain_Level10To11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Captain_Level12To13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Captain_Level14To15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Captain_Level16To17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Captain_Level18To19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Captain_Level2To3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Captain_Level4To5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Captain_Level6To7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Captain_Level8To9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Guard_Level1, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Guard_Level10To11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Guard_Level12To13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Guard_Level14To15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Guard_Level16To17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Guard_Level18To19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Guard_Level2To3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Guard_Level4To5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Guard_Level6To7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Guard_Level8To9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Leader_Level10To11, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Leader_Level12To13, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Leader_Level14To15, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Leader_Level16To17, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Leader_Level18To19, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Leader_Level2To3, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Leader_Level4To5, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Leader_Level6To7, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Warrior_Leader_Level8To9, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Annis, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.GreenHag, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.SeaHag, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Halfling_Lightfoot_Captain, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Halfling_Lightfoot_Leader, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Halfling_Lightfoot_Lieutenant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Halfling_Lightfoot_Noncombatant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Halfling_Lightfoot_Sergeant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Halfling_Lightfoot_Warrior, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Halfling_Deep_Captain, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Halfling_Deep_Leader, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Halfling_Deep_Lieutenant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Halfling_Deep_Noncombatant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Halfling_Deep_Sergeant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Halfling_Deep_Warrior, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Halfling_Tallfellow_Captain, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Halfling_Tallfellow_Leader, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Halfling_Tallfellow_Lieutenant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Halfling_Tallfellow_Noncombatant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Halfling_Tallfellow_Sergeant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Halfling_Tallfellow_Warrior, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Harpy, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.HarpyArcher, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Hydra_10Heads, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Hydra_11Heads, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Hydra_12Heads, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Hydra_5Heads, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Hydra_6Heads, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Hydra_7Heads, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Hydra_8Heads, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Hydra_9Heads, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Cryohydra_10Heads, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Cryohydra_11Heads, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Cryohydra_12Heads, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Cryohydra_5Heads, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Cryohydra_6Heads, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Cryohydra_7Heads, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Cryohydra_8Heads, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Cryohydra_9Heads, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Pyrohydra_10Heads, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Pyrohydra_11Heads, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Pyrohydra_12Heads, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Pyrohydra_5Heads, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Pyrohydra_6Heads, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Pyrohydra_7Heads, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Pyrohydra_8Heads, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Pyrohydra_9Heads, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Howler, EnvironmentConstants.Plane_Chaotic)]
        [TestCase(CreatureConstants.Homunculus, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Hobgoblin_Leader_4thTo6th, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Hobgoblin_Leader_6thTo8th, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Hobgoblin_Lieutenant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Hobgoblin_Noncombatant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Hobgoblin_Sergeant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Hobgoblin_Warrior, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Hippogriff, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.HellHound, EnvironmentConstants.Plane_LawfulEvil)]
        [TestCase(CreatureConstants.NessianWarhound, EnvironmentConstants.Plane_LawfulEvil)]
        [TestCase(CreatureConstants.Kolyarut, EnvironmentConstants.Plane_Lawful)]
        [TestCase(CreatureConstants.Marut, EnvironmentConstants.Plane_Lawful)]
        [TestCase(CreatureConstants.Zelekhut, EnvironmentConstants.Plane_Lawful)]
        [TestCase(CreatureConstants.InvisibleStalker, EnvironmentConstants.Plane_Air)]
        [TestCase(CreatureConstants.Kobold_Leader_4thTo6th, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Kobold_Leader_6thTo8th, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Kobold_Lieutenant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Kobold_Noncombatant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Kobold_Sergeant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Kobold_Warrior, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Kraken, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Krenshar, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Lamia, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Lammasu, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Lammasu_GoldenProtector, EnvironmentConstants.Plane_LawfulGood)]
        [TestCase(CreatureConstants.Leonal, EnvironmentConstants.Plane_Good)]
        [TestCase(CreatureConstants.Lich_Level11, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Lich_Level12, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Lich_Level13, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Lich_Level14, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Lich_Level15, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Lich_Level16, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Lich_Level17, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Lich_Level18, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Lich_Level19, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Lich_Level20, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Lillend, EnvironmentConstants.Plane_Chaotic)]
        [TestCase(CreatureConstants.Lizardfolk, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Lizardfolk_Leader_3rdTo6th, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Lizardfolk_Leader_4thTo10th, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Lizardfolk_Lieutenant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Lizardfolk_Noncombatant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Locathah_Captain, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Locathah_Leader, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Locathah_Lieutenant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Locathah_Noncombatant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Locathah_Sergeant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Locathah_Warrior, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Werebear, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Wereboar, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Wereboar_HillGiantDire, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Wererat, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Weretiger, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Werewolf, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.WerewolfLord, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Magmin, EnvironmentConstants.Plane_Fire)]
        [TestCase(CreatureConstants.Manticore, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Medusa, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Mephit_Air, EnvironmentConstants.Plane_Air)]
        [TestCase(CreatureConstants.Mephit_Dust, EnvironmentConstants.Plane_Air)]
        [TestCase(CreatureConstants.Mephit_Earth, EnvironmentConstants.Plane_Earth)]
        [TestCase(CreatureConstants.Mephit_Fire, EnvironmentConstants.Plane_Fire)]
        [TestCase(CreatureConstants.Mephit_Ice, EnvironmentConstants.Plane_Air)]
        [TestCase(CreatureConstants.Mephit_Magma, EnvironmentConstants.Plane_Fire)]
        [TestCase(CreatureConstants.Mephit_Ooze, EnvironmentConstants.Plane_Water)]
        [TestCase(CreatureConstants.Mephit_Salt, EnvironmentConstants.Plane_Earth)]
        [TestCase(CreatureConstants.Mephit_Steam, EnvironmentConstants.Plane_Fire)]
        [TestCase(CreatureConstants.Mephit_Water, EnvironmentConstants.Plane_Water)]
        [TestCase(CreatureConstants.Merfolk_Captain, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Merfolk_Leader, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Merfolk_Lieutenant_3rd, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Merfolk_Lieutenant_5th, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Merfolk_Sergeant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Merfolk_Warrior, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Mimic, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Minotaur, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Mohrg, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Mummy, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.MummyLord, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Naga_Dark, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Naga_Guardian, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Naga_Spirit, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Naga_Water, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.NightHag, EnvironmentConstants.Plane_Evil)]
        [TestCase(CreatureConstants.Nightmare, EnvironmentConstants.Plane_Evil)]
        [TestCase(CreatureConstants.Nightmare_Cauchemar, EnvironmentConstants.Plane_NeutralEvil)]
        [TestCase(CreatureConstants.Nightcrawler, EnvironmentConstants.Plane_Shadow)]
        [TestCase(CreatureConstants.Nightwalker, EnvironmentConstants.Plane_Shadow)]
        [TestCase(CreatureConstants.Nightwing, EnvironmentConstants.Plane_Shadow)]
        [TestCase(CreatureConstants.Nymph, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Ogre, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Ogre_Barbarian, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Ogre_Merrow, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Ogre_Merrow_Barbarian, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.OgreMage, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.BlackPudding, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.BlackPudding_Elder, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.GelatinousCube, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Ooze_Gray, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Ooze_OchreJelly, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Orc_Captain, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Orc_Leader, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Orc_Lieutenant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Orc_Noncombatant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Orc_Sergeant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Orc_Warrior, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Orc_Half_Captain, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Orc_Half_Captain, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Orc_Half_Leader, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Orc_Half_Leader, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Orc_Half_Lieutenant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Orc_Half_Lieutenant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Orc_Half_Noncombatant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Orc_Half_Noncombatant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Orc_Half_Sergeant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Orc_Half_Sergeant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Orc_Half_Warrior, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Orc_Half_Warrior, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Otyugh, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Owl_Giant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Owlbear, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Pegasus, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.PhantomFungus, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.PhaseSpider, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Phasm, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Aasimar_Warrior, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Tiefling_Warrior, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Pseudodragon, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.PurpleWorm, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Rakshasa, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Rast, EnvironmentConstants.Plane_Fire)]
        [TestCase(CreatureConstants.Ravid, EnvironmentConstants.Plane_PositiveEnergy)]
        [TestCase(CreatureConstants.RazorBoar, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.RazorBoar, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.RazorBoar, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.RazorBoar, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Remorhaz, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Roc, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Roper, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.RustMonster, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.ShockerLizard, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.ShieldGuardian, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.ShamblingMound, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.ShadowMastiff, EnvironmentConstants.Plane_Shadow)]
        [TestCase(CreatureConstants.Shadow, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Shadow_Greater, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.SeaCat, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Scorpionfolk, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Scorpionfolk, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Scorpionfolk, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Satyr, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Satyr_WithPipes, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Salamander_Average, EnvironmentConstants.Plane_Fire)]
        [TestCase(CreatureConstants.Salamander_Flamebrother, EnvironmentConstants.Plane_Fire)]
        [TestCase(CreatureConstants.Salamander_Noble, EnvironmentConstants.Plane_Fire)]
        [TestCase(CreatureConstants.Sahuagin, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Sahuagin_Baron, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Sahuagin_Chieftan, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Sahuagin_Guard, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Sahuagin_Lieutenant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Sahuagin_Noncombatant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Sahuagin_Priest, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Sahuagin_Underpriest, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Skeleton_Chimera, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Skeleton_Chimera, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Skeleton_Dragon_Red_YoungAdult, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Skeleton_Dragon_Red_YoungAdult, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Skeleton_Ettin, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Skeleton_Ettin, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Skeleton_Giant_Cloud, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Skeleton_Giant_Cloud, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Skeleton_Human, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Skeleton_Human, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Skeleton_Megaraptor, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Skeleton_Megaraptor, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Skeleton_Owlbear, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Skeleton_Owlbear, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Skeleton_Troll, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Skeleton_Troll, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Skeleton_Wolf, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Skeleton_Wolf, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Skum, EnvironmentConstants.Underground + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Spectre, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Spectre, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Androsphinx, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Criosphinx, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Gynosphinx, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Hieracosphinx, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.SpiderEater, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Grig, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Nixie, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Pixie, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Pixie_WithIrresistableDance, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Stirge, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Bat_Swarm, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Centipede_Swarm, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Hellwasp_Swarm, EnvironmentConstants.Plane_Evil)]
        [TestCase(CreatureConstants.Locust_Swarm, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Rat_Swarm, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Spider_Swarm, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Tarrasque, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Tendriculos, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Thoqqua, EnvironmentConstants.Plane_Fire)]
        [TestCase(CreatureConstants.Titan, EnvironmentConstants.Plane_ChaoticGood)]
        [TestCase(CreatureConstants.Tojanida_Adult, EnvironmentConstants.Plane_Water)]
        [TestCase(CreatureConstants.Tojanida_Elder, EnvironmentConstants.Plane_Water)]
        [TestCase(CreatureConstants.Tojanida_Juvenile, EnvironmentConstants.Plane_Water)]
        [TestCase(CreatureConstants.Treant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Triton, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Troglodyte, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Troglodyte_Noncombatant, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Troll, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Troll_Hunter, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Troll_Scrag, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Troll_Scrag_Hunter, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Unicorn, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Unicorn_CelestialCharger, EnvironmentConstants.Plane_ChaoticGood)]
        [TestCase(CreatureConstants.Vampire_Level1, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Vampire_Level10, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Vampire_Level11, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Vampire_Level12, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Vampire_Level13, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Vampire_Level14, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Vampire_Level15, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Vampire_Level16, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Vampire_Level17, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Vampire_Level18, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Vampire_Level19, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Vampire_Level2, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Vampire_Level20, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Vampire_Level3, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Vampire_Level4, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Vampire_Level5, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Vampire_Level6, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Vampire_Level7, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Vampire_Level8, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Vampire_Level9, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.VampireSpawn, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Vargouille, EnvironmentConstants.Plane_Evil)]
        [TestCase(CreatureConstants.Wight, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.WillOWisp, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.WinterWolf, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Worg, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Wraith, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Wraith_Dread, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Wyvern, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Xill, EnvironmentConstants.Plane_Ethereal)]
        [TestCase(CreatureConstants.Xorn_Average, EnvironmentConstants.Plane_Earth)]
        [TestCase(CreatureConstants.Xorn_Elder, EnvironmentConstants.Plane_Earth)]
        [TestCase(CreatureConstants.Xorn_Minor, EnvironmentConstants.Plane_Earth)]
        [TestCase(CreatureConstants.YethHound, EnvironmentConstants.Plane_Evil)]
        [TestCase(CreatureConstants.Yrthak, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Zombie_Kobold, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Zombie_Kobold, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Zombie_Kobold, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Zombie_Human, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Zombie_Human, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Zombie_Human, EnvironmentConstants.Any)]
        [TestCase(CreatureConstants.Zombie_Troglodyte, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Zombie_Troglodyte, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Zombie_Bugbear, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Zombie_Bugbear, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Zombie_Bugbear, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Zombie_Ogre, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Zombie_Ogre, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Zombie_Ogre, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Zombie_Minotaur, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Zombie_Minotaur, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Zombie_Wyvern, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Zombie_Wyvern, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Zombie_Wyvern, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Zombie_GrayRender, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Zombie_GrayRender, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Zombie_GrayRender, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Ape, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Baboon, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Badger, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Bat, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Bear_Black, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Bear_Brown, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Bear_Polar, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Bison, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Boar, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Camel, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Cat, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Cat, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Cheetah, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Crocodile, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Crocodile_Giant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Dog, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Dog, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Dog_Riding, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Dog_Riding, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Donkey, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Donkey, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Eagle, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Mountain)]
        [TestCase(CreatureConstants.Elephant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Hawk, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Horse_Heavy, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Horse_Heavy, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Horse_Heavy_War, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Horse_Heavy_War, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Horse_Light, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Horse_Light, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Horse_Light_War, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Horse_Light_War, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Hyena, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Leopard, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Lion, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Lizard, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Lizard_Monitor, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.MantaRay, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Monkey, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Mule, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Mule, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Octopus, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Octopus_Giant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Owl, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Pony, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Pony, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Pony_War, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Pony_War, EnvironmentConstants.Civilized)]
        [TestCase(CreatureConstants.Porpoise, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Rat, EnvironmentConstants.Land)]
        [TestCase(CreatureConstants.Raven, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Rhinoceras, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Shark_Medium, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Shark_Large, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Shark_Huge, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Snake_Constrictor, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Snake_Constrictor_Giant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Snake_Viper_Tiny, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Snake_Viper_Small, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Snake_Viper_Medium, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Snake_Viper_Large, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Snake_Viper_Huge, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Squid, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Squid_Giant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Tiger, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Toad, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Marsh)]
        [TestCase(CreatureConstants.Weasel, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Whale_Baleen, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Whale_Cachalot, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Whale_Orca, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Wolf, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Wolverine, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Ant_Giant_Queen, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Ant_Giant_Soldier, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Ant_Giant_Worker, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.Bee_Giant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.BombardierBeetle_Giant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.FireBeetle_Giant, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Plains)]
        [TestCase(CreatureConstants.StagBeetle_Giant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.PrayingMantis_Giant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Wasp_Giant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Centipede_Monstrous_Colossal, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Centipede_Monstrous_Gargantuan, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Centipede_Monstrous_Huge, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Centipede_Monstrous_Large, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Centipede_Monstrous_Medium, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Centipede_Monstrous_Small, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Centipede_Monstrous_Tiny, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.Scorpion_Monstrous_Colossal, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Scorpion_Monstrous_Gargantuan, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Scorpion_Monstrous_Huge, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Scorpion_Monstrous_Large, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Scorpion_Monstrous_Medium, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Scorpion_Monstrous_Small, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Scorpion_Monstrous_Tiny, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Desert)]
        [TestCase(CreatureConstants.Spider_Monstrous_Colossal, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Spider_Monstrous_Gargantuan, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Spider_Monstrous_Huge, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Spider_Monstrous_Large, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Spider_Monstrous_Medium, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Spider_Monstrous_Small, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Spider_Monstrous_Tiny, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.Beholder, EnvironmentConstants.Temperatures.Cold + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.CarrionCrawler, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.DisplacerBeast, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.DisplacerBeast_PackLord, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Hills)]
        [TestCase(CreatureConstants.Githyanki_Captain, EnvironmentConstants.Plane_Astral)]
        [TestCase(CreatureConstants.Githyanki_Fighter, EnvironmentConstants.Plane_Astral)]
        [TestCase(CreatureConstants.Githyanki_Lieutenant, EnvironmentConstants.Plane_Astral)]
        [TestCase(CreatureConstants.Githyanki_Sergeant, EnvironmentConstants.Plane_Astral)]
        [TestCase(CreatureConstants.Githyanki_SupremeLeader, EnvironmentConstants.Plane_Astral)]
        [TestCase(CreatureConstants.Githzerai_Master, EnvironmentConstants.Plane_Limbo)]
        [TestCase(CreatureConstants.Githzerai_Mentor, EnvironmentConstants.Plane_Limbo)]
        [TestCase(CreatureConstants.Githzerai_Sensei, EnvironmentConstants.Plane_Limbo)]
        [TestCase(CreatureConstants.Githzerai_Student, EnvironmentConstants.Plane_Limbo)]
        [TestCase(CreatureConstants.Githzerai_Teacher, EnvironmentConstants.Plane_Limbo)]
        [TestCase(CreatureConstants.MindFlayer, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.MindFlayer_Sorcerer, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.KuoToa, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.KuoToa_Fighter_10th, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.KuoToa_Fighter_8th, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.KuoToa_Monitor, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.KuoToa_Noncombatant, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.KuoToa_Whip_10th, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.KuoToa_Whip_3rd, EnvironmentConstants.Temperatures.Temperate + EnvironmentConstants.Aquatic)]
        [TestCase(CreatureConstants.Slaad_Blue, EnvironmentConstants.Plane_Limbo)]
        [TestCase(CreatureConstants.Slaad_Death, EnvironmentConstants.Plane_Limbo)]
        [TestCase(CreatureConstants.Slaad_Gray, EnvironmentConstants.Plane_Limbo)]
        [TestCase(CreatureConstants.Slaad_Green, EnvironmentConstants.Plane_Limbo)]
        [TestCase(CreatureConstants.Slaad_Red, EnvironmentConstants.Plane_Limbo)]
        [TestCase(CreatureConstants.UmberHulk, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.UmberHulk_TrulyHorrid, EnvironmentConstants.Underground)]
        [TestCase(CreatureConstants.YuanTi_Pureblood, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.YuanTi_Halfblood, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        [TestCase(CreatureConstants.YuanTi_Abomination, EnvironmentConstants.Temperatures.Warm + EnvironmentConstants.Forest)]
        public void CreatureIsInCorrectEnvironment(string creature, string environment)
        {
            var creatures = collectionSelector.Explode(TableNameConstants.CreatureGroups, environment);
            Assert.That(creatures, Contains.Item(creature));
        }
    }
}
