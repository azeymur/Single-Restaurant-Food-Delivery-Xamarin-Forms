using System.Collections.Generic;
using FoodDeliveryTemplate.Models;

namespace FoodDeliveryTemplate.DataStores.MockDataStore
{
    /// <summary>
    /// Mock data store with fake entities to test.
    /// </summary>
    public class FavoriteDataStore : BaseDataStore<Favorite>, IFavoriteDataStore
    {
        protected override IList<Favorite> items { get; }

        public FavoriteDataStore()
        {
            items = new List<Favorite>
            {
                new Favorite { Id = "fav001", CustomerId = "cu001", ItemId = "i010" },

                new Favorite { Id = "fav002", CustomerId = "cu001", ItemId = "i016" },

                new Favorite { Id = "fav003", CustomerId = "cu001", ItemId = "i017" },

                new Favorite { Id = "fav004", CustomerId = "cu001", ItemId = "i023" },

                new Favorite { Id = "fav005", CustomerId = "cu001", ItemId = "i025" },

                new Favorite { Id = "fav006", CustomerId = "cu001", ItemId = "i027" },
            };
        }
    }
}
