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

        /*
         Improvements:
         1. UpdatePropertiesForPeriodOfTime()
         2. Validation of input data (quality for Sulfuras == 80, startin quality for General items <= 50, etc).
          
         */

        public void UpdatePropertiesForOneDay()
        {
            foreach (var item in Items)
            {
                item.UpdateProperties();
            }
        }
    }
}