namespace GuildedRoseKata.Behaviours
{
    public class BackstagePassessBehaviour : IUpdateBehaviour
    {
        public UpdatableProperties UpdateProperties(UpdatableProperties updatableProperties)
        {
            int updatedQuality = 0;

            if (updatableProperties.SellIn > 10)
            {
                updatedQuality = updatableProperties.Quality + 1;
            }

            if (updatableProperties.SellIn > 5 && updatableProperties.SellIn <= 10)
            {
                updatedQuality = updatableProperties.Quality + 2;
            } 

            if (updatableProperties.SellIn > 0 && updatableProperties.SellIn <= 5)
            {
                updatedQuality = updatableProperties.Quality + 3;
            } 

            return new UpdatableProperties(updatableProperties.SellIn - 1, updatedQuality);
        }
    }
}
