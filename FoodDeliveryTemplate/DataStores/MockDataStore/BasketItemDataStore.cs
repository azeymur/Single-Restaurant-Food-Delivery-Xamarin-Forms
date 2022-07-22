using System;
using System.Collections.Generic;
using FoodDeliveryTemplate.Models;

namespace FoodDeliveryTemplate.DataStores.MockDataStore
{
    /// <summary>
    /// Mock data store with fake entities to test.
    /// </summary>
    public class BasketItemDataStore : BaseDataStore<BasketItem>, ICartItemDataStore
    {
        protected override IList<BasketItem> items { get; }

        public BasketItemDataStore()
        {
            items = new List<BasketItem>
            {
                new BasketItem
                {
                    Id = Guid.NewGuid().ToString(),
                    ProductName = "Chicken Fajitas",
                    ProductImage = "mi_chicken_fajitas",
                    UnitPrice = 15,
                    Quantity = 1,
                    IngredientString = "Onion",
                    ChoiceString = "Apple slice · Mushroom"
                },

            };
        }
    }
}
