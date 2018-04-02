using System;

namespace GuildedRoseKata
{
    public class GeneralBehaviour : IUpdateBehaviour
    {
        public int UpdateQuality(int quality)
        {
            return quality - 1;
        }

        public int UpdateSellIn(int sellIn)
        {
            return sellIn - 1;
        }
    }
}
