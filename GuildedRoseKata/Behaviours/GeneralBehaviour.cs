namespace GuildedRoseKata.Behaviours
{
    public class GeneralBehaviour : IUpdateBehaviour
    {
        public UpdatableProperties UpdateProperties(UpdatableProperties updatableProperties)
        {
            int quality;

            if (updatableProperties.SellIn <= 0)
            {
                quality = updatableProperties.Quality - 2;
            }
            else
            {
                quality = updatableProperties.Quality - 1;
            }

            if (quality < 0)
            {
                quality = 0;
            }

            return new UpdatableProperties(updatableProperties.SellIn - 1, quality);
        }
    }
}
