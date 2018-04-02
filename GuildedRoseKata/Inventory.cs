using System;
using System.Collections.Generic;

namespace GuildedRoseKata
{
    public class Inventory
    {
        public List<Item> Items { get; }

        public Inventory(List<Item> items)
        {
            Items = items;
        }

        public void UpdateProperties()
        {
            foreach (var item in Items)
            {
                item.Update();
            }
        }
    }
}