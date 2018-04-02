using System;
using System.Collections.Generic;
using GuildedRoseKata.Behaviours;

namespace GuildedRoseKata
{
    public static class BehaviorDefiner
    {
        private static Dictionary<string, IUpdateBehaviour> BehaviourByItemName = new Dictionary<string, IUpdateBehaviour>
        {
            { "Aged Brie", new AgedBrieBehaviour() },
            { "Sulfuras, Hand of Ragnaros", new SulfurasBehaviour() },
            { "Backstage passes", new BackstagePassessBehaviour() }
        };

        public static IUpdateBehaviour DefineStrategyBasedOnName(string name)
        {
            if (BehaviourByItemName.ContainsKey(name))
                return BehaviourByItemName[name];

            return new GeneralBehaviour();
        }
    }
}
