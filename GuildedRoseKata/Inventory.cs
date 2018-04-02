using System;
using System.Collections.Generic;

namespace GuildedRoseKata
{
    public class Inventory
    {
        public IList<Item> Items { get; }

        public Inventory(IList<Item> items)
        {
            Items = items;
        }

		public void UpdateProperties()
		{
			
		}
	}
}