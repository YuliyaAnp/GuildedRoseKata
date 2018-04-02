using System;
using System.Collections.Generic;

namespace GuildedRoseKata
{
    public class Item
    {
        public Item(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
            UpdateBehaviour = DefineStrategyBasedOnName(name);
        }

        public string Name { get; private set; }
        public int SellIn { get; private set; }
        public int Quality { get; private set; }
        public IUpdateBehaviour UpdateBehaviour { get; }

        private Dictionary<string, IUpdateBehaviour> BehaviourByItemName = new Dictionary<string, IUpdateBehaviour>
        {
            { "Aged Brie", new AgedBrieBehaviour() },
            { "Sulfuras, Hand of Ragnaros", new SulfurasBehaviour() },
            { "Backstage passes", new BackstagePassessBehaviour() }
        };

        public void UpdateProperties()
        {
            SellIn = UpdateBehaviour.UpdateSellIn(SellIn);
            Quality = UpdateBehaviour.UpdateQuality(Quality);
        }

        private IUpdateBehaviour DefineStrategyBasedOnName(string name)
        {
            if (BehaviourByItemName.ContainsKey(name))
                return BehaviourByItemName[name];

            return new GeneralBehaviour();
        }
    }
}