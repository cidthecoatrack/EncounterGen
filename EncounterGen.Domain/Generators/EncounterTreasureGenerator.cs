﻿using EncounterGen.Common;
using EncounterGen.Domain.Selectors;
using EncounterGen.Domain.Selectors.Percentiles;
using EncounterGen.Domain.Tables;
using System;
using System.Linq;
using TreasureGen;
using TreasureGen.Coins;
using TreasureGen.Goods;
using TreasureGen.Items;

namespace EncounterGen.Domain.Generators
{
    internal class EncounterTreasureGenerator : IEncounterTreasureGenerator
    {
        private const int IterationLimit = 10000;

        private ICoinGenerator coinGenerator;
        private IGoodsGenerator goodsGenerator;
        private IItemsGenerator itemsGenerator;
        private IAdjustmentSelector adjustmentSelector;
        private IBooleanPercentileSelector booleanPercentileSelector;
        private ICollectionSelector collectionSelector;

        public EncounterTreasureGenerator(ICoinGenerator coinGenerator, IGoodsGenerator goodsGenerator, IItemsGenerator itemsGenerator, IAdjustmentSelector adjustmentSelector,
            IBooleanPercentileSelector booleanPercentileSelector, ICollectionSelector collectionSelector)
        {
            this.coinGenerator = coinGenerator;
            this.goodsGenerator = goodsGenerator;
            this.itemsGenerator = itemsGenerator;
            this.adjustmentSelector = adjustmentSelector;
            this.booleanPercentileSelector = booleanPercentileSelector;
            this.collectionSelector = collectionSelector;
        }

        public Treasure GenerateFor(Creature creature, int level)
        {
            var creatureType = GetTypeForTreasure(creature);
            var coinMultiplier = adjustmentSelector.Select<double>(TableNameConstants.TreasureAdjustments, creatureType, TreasureConstants.Coin);
            var goodsMultiplier = adjustmentSelector.Select<double>(TableNameConstants.TreasureAdjustments, creatureType, TreasureConstants.Goods);
            var itemsMultiplier = adjustmentSelector.Select<double>(TableNameConstants.TreasureAdjustments, creatureType, TreasureConstants.Items);

            var treasure = new Treasure();
            treasure.Coin = coinGenerator.GenerateAtLevel(level);

            var doubleQuantity = coinMultiplier * treasure.Coin.Quantity;
            treasure.Coin.Quantity = Convert.ToInt32(doubleQuantity);

            while (booleanPercentileSelector.SelectFrom(goodsMultiplier--))
            {
                var goods = goodsGenerator.GenerateAtLevel(level);
                treasure.Goods = treasure.Goods.Union(goods);
            }

            while (booleanPercentileSelector.SelectFrom(itemsMultiplier--))
            {
                var items = itemsGenerator.GenerateAtLevel(level);
                treasure.Items = treasure.Items.Union(items);
            }

            return treasure;
        }

        private string GetTypeForTreasure(Creature creature)
        {
            var useSubtypeForTreasure = collectionSelector.SelectFrom(TableNameConstants.CreatureGroups, GroupConstants.UseSubtypeForTreasure);

            if (useSubtypeForTreasure.Contains(creature.Name))
                return creature.Description;

            return creature.Name;
        }
    }
}