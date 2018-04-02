using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace GuildedRoseKata.UnitTests
{
    [TestFixture]
    public class UpdateInventoryShould
    {
        [TestCase("Test", 4, 9, 5, 10)]
        [TestCase("Aged Brie", 4, 11, 5, 10)]
        [TestCase("Sulfuras, Hand of Ragnaros", 0, 80, 0, 80)]
        [TestCase("Backstage passes", 15, 10, 16, 9)]
        [TestCase("Backstage passes", 9, 11, 10, 9)]
        public void UpdatePropertiesOfItemCorrectly_AfterOneDay(string itemName, int expectedSellIn, int expectedQuality,
                                                                       int inputSellIn, int inputQuality)
        {
            var expectedItems = new List<Item>() { new Item(itemName, expectedSellIn, expectedQuality ) };

            var items = new List<Item>() { new Item(itemName, inputSellIn, inputQuality) };
            var inventory = new Inventory(items);

            inventory.UpdatePropertiesForOneDay();

            var actualItems = inventory.Items;

            actualItems.Should().BeEquivalentTo(expectedItems);
        }
    }
}
