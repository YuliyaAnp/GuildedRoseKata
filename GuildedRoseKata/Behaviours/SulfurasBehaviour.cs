namespace GuildedRoseKata.Behaviours
{
    public class SulfurasBehaviour : IUpdateBehaviour
    {
        public UpdatableProperties UpdateProperties(UpdatableProperties updatableProperties)
        {
            return new UpdatableProperties(updatableProperties.SellIn, updatableProperties.Quality);
        }
    }
}
