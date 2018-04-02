namespace GuildedRoseKata
{
    public class GeneralBehaviour : IUpdateBehaviour
    {
        public UpdatableProperties UpdateProperties(UpdatableProperties updatableProperties)
        {
            return new UpdatableProperties(updatableProperties.SellIn - 1, updatableProperties.Quality - 1);
        }
    }
}
