using GuildedRoseKata.Behaviours;

namespace GuildedRoseKata
{
    public class Item
    {
        public Item(string name, int sellIn, int quality)
        {
            Name = name;
            ItemUpdatableProperties = new UpdatableProperties(sellIn, quality);
            UpdateBehaviour = BehaviorDefiner.DefineStrategyBasedOnName(name);
        }

        public string Name { get; private set; }
        public UpdatableProperties ItemUpdatableProperties { get; private set; }
        public IUpdateBehaviour UpdateBehaviour { get; }

        public void UpdateProperties()
        {
            var updatedProperties = UpdateBehaviour.UpdateProperties(ItemUpdatableProperties);
            ItemUpdatableProperties = updatedProperties;
        }


    }
}