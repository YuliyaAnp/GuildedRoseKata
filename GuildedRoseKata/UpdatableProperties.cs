namespace GuildedRoseKata
{
    public class UpdatableProperties
    {
        public UpdatableProperties(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = quality;
        }

        public int SellIn { get; }
        public int Quality { get; }
    }
}