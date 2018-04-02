using System;

namespace GuildedRoseKata
{
    public class Item
    {
        public Item(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public string Name { get; private set; }
        public int SellIn { get; private set; }
        public int Quality { get; private set; }

        internal void Update()
        {
            Quality = Quality - 1;
            SellIn = SellIn - 1;
        }
    }
}