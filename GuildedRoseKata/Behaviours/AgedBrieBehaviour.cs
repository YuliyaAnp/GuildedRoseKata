namespace GuildedRoseKata.Behaviours
{
    public class AgedBrieBehaviour : IUpdateBehaviour
    {
        public UpdatableProperties UpdateProperties(UpdatableProperties updatableProperties)
        {
            int quality = updatableProperties.Quality;

            if (updatableProperties.Quality < 50)
            {
                quality = updatableProperties.Quality + 1;
            }

            return new UpdatableProperties(updatableProperties.SellIn - 1, quality);
        }
    }
}
