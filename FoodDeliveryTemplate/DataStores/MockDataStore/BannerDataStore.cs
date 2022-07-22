using System.Collections.Generic;
using FoodDeliveryTemplate.Models;

namespace FoodDeliveryTemplate.DataStores.MockDataStore
{
    /// <summary>
    /// Mock data store with fake entities to test.
    /// </summary>
    public class BannerDataStore : BaseDataStore<Banner>, IBannerDataStore
    {
        protected override IList<Banner> items { get; }

        public BannerDataStore()
        {
            items = new List<Banner>
            {
                new Banner { Id = "ban001", Image = "banner_food1",
                            GoTo = "ItemsPage?CategoryId=c005&OnlySale=true&Title=Pastas on Sale" },

                new Banner { Id = "ban002", Image = "banner_food2",
                            GoTo = "ItemsPage?CategoryId=c008&OnlySale=true&Title=Beverages on Sale" },
            };
        }
        
    }
}
