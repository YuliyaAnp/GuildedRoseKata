using System;
namespace GuildedRoseKata
{
    public class SulfurasBehaviour : IUpdateBehaviour
    {
        public int UpdateQuality(int quality)
        {
            return quality;
        }

        public int UpdateSellIn(int sellIn)
        {
            return sellIn;
        }
    }
}
