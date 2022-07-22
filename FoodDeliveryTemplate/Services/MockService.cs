using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryTemplate.DataStores;
using FoodDeliveryTemplate.Models;
using Xamarin.Forms;

namespace FoodDeliveryTemplate.Services
{
    /// <summary>
    /// Mock service that works with mock data stores for testing.
    /// </summary>
    public class MockService : IService
    {
        IBannerDataStore dataBanner => DependencyService.Get<IBannerDataStore>();
        ICategoryDataStore dataCategory => DependencyService.Get<ICategoryDataStore>();
        IItemDataStore dataItem => DependencyService.Get<IItemDataStore>();
        ICustomerDataStore dataCustomer = DependencyService.Get<ICustomerDataStore>();
        ICartItemDataStore dataCartItem => DependencyService.Get<ICartItemDataStore>();
        IFavoriteDataStore dataFavorite => DependencyService.Get<IFavoriteDataStore>();

        // Methods for Category entity

        public async Task<IEnumerable<Category>> GetCategoriesAsync(string name)
        {
            var result = await dataCategory.GetByAsync(i => name == null || i.Name.Contains(name));

            return await Task.FromResult(result);
        }

        // Methods for Banner entity

        public async Task<IEnumerable<Banner>> GetBannersAsync()
        {
            return await dataBanner.GetAllAsync();
        }

        // Methods for item entity

        public async Task<Item> GetItemAsync(string id)
        {
            return await dataItem.GetAsync(id);
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(string categoryId = null, string key = null,
                                            bool onlyFavorite = false, bool onlyFeatured = false,
                                            bool onlyPopular = false, bool onlySale = false)
        {
            var result = (await dataItem.GetByAsync(p => (categoryId == null || p.CategoryId == categoryId) &&
                                            (key == null || p.Name.ToLower().Contains(key.ToLower())) &&
                                            (onlyFeatured == false || p.IsFeatured == true) &&
                                            (onlyPopular == false || p.IsPopular == true) &&
                                            (onlySale == false || p.OnSale == true))).ToList()
                                            .Select(i =>
                                            {
                                                i.IsFavorite = IsFavoriteAsync(Globals.LoggedCustomerId, i.Id).Result;
                                                return i;
                                            }).Where(p => onlyFavorite == false || p.IsFavorite == true);

            return result;
        }

        // Methods for Customer entity

        public async Task<Customer> GetCustomerAsync(string id)
        {
            return await dataCustomer.GetAsync(id);
        }

        // Methods for CartItem entity

        public async Task<BasketItem> GetCartItemAsync(string id)
        {
            return await dataCartItem.GetAsync(id);
        }

        public async Task<BasketItem> AddCartItemAsync(BasketItem cartItem)
        {
            var oldItem = dataCartItem.GetByAsync(i => i.ProductName == cartItem.ProductName &&
                                                        i.IngredientString == cartItem.IngredientString &&
                                                        i.ChoiceString == cartItem.ChoiceString &&
                                                        i.UnitPrice == cartItem.UnitPrice)
                            .Result.FirstOrDefault();

            if (oldItem == null)
                return await dataCartItem.AddAsync(cartItem);
            else
            {
                oldItem.Quantity += cartItem.Quantity;
                await dataCartItem.UpdateAsync(oldItem);
                return oldItem;
            }
        }

        public async Task<bool> UpdateCartItemAsync(BasketItem cartItem)
        {
            return await dataCartItem.UpdateAsync(cartItem);
        }

        public async Task<IEnumerable<BasketItem>> GetCartItemsAsync()
        {
            var result = (await dataCartItem.GetAllAsync());

            return await Task.FromResult(result);
        }

        public async Task<bool> DeleteCartItemAsync(string id)
        {
            return await dataCartItem.DeleteAsync(id);
        }

        public async Task<bool> DeleteAllCartItemsAsync()
        {
            return await dataCartItem.DeleteAllAsync();
        }

        // Methods for Favorite entity

        public async Task<Favorite> AddFavoriteAsync(Favorite favorite)
        {
            return await dataFavorite.AddAsync(favorite);
        }

        public async Task<bool> DeleteFavoriteAsync(string id)
        {
            return await dataFavorite.DeleteAsync(id);
        }

        public async Task<bool> IsFavoriteAsync(string customerId, string itemId)
        {
            return await dataFavorite.IsExistAsync(f => f.CustomerId == customerId && f.ItemId == itemId);
        }

        public async Task<Favorite> GetFavoriteAsync(string customerId, string itemId)
        {
            return (await dataFavorite.GetByAsync(f => f.CustomerId == customerId && f.ItemId == itemId))
                        .FirstOrDefault();
        }

    }
}
