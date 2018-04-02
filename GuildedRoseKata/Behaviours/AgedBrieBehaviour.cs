namespace GuildedRoseKata.Behaviours
{
    public class AgedBrieBehaviour : IUpdateBehaviour
    {
        public UpdatableProperties UpdateProperties(UpdatableProperties updatableProperties)
        {
            return new UpdatableProperties(updatableProperties.SellIn - 1, updatableProperties.Quality + 1);
        }
    }
}
