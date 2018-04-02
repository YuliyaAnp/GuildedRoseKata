using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace GuildedRoseKata.UnitTests
{
    [TestFixture]
    public class UpdateInventoryShould
    {
        [Test]
        public void UpdatePropertiesOfGeneralItemCorrectly_AfterOneDay()
        {
            var expectedItems = new List<Item>() { new Item("Test", 4, 9 ) };

            var items = new List<Item>() { new Item("Test", 5, 10) };
            var inventory = new Inventory(items);

            inventory.UpdateProperties();

            var actualItems = inventory.Items;

            actualItems.Should().BeEquivalentTo(expectedItems);
        }

        [Test]
        public void UpdatePropertiesOfAgedBrieItemCorrectly_AfterOneDay()
        {
            var expectedItems = new List<Item>() { new Item("Aged Brie", 4, 11) };

            var items = new List<Item>() { new Item("Aged Brie", 5, 10) };
            var inventory = new Inventory(items);

            inventory.UpdateProperties();

            var actualItems = inventory.Items;

            actualItems.Should().BeEquivalentTo(expectedItems);
        }
    }
}
