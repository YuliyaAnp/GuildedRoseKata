using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace GuildedRoseKata.Tests
{
    [TestFixture]
    public class UpdateInventoryShould
    {
        [Test]
        public void UpdatePropertiesOfGeneralItemCorrectly_AfterOneDay()
        {
            var expectedItems = new List<Item>() { new Item() { Name = "Test", SellInDate = 4, Quality = 9 } };

            var items = new List<Item>() { new Item() { Name = "Test", SellInDate = 5, Quality = 10 }};
            var inventory = new Inventory(items);

            inventory.UpdateProperties();

            var actualItems = inventory.Items;

            actualItems.Should().BeEquivalentTo(expectedItems);
        }
    }
}
