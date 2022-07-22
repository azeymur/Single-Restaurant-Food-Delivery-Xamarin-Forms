using System.Collections.Generic;
using System.Threading.Tasks;
using FoodDeliveryTemplate.Models;

namespace FoodDeliveryTemplate.Services
{
    /// <summary>
    /// Interface with common tasks
    /// </summary>
    public interface IService
    {
        /// <summary>
        /// Get the product by id
        /// </summary>
        /// <param name="id">product id</param>
        /// <returns>Product object or null</returns>
        Task<Item> GetItemAsync(string id);

        /// <summary>
        /// Get products by parameters
        /// </summary>
        /// <param name="categoriId">Category id. Default is null.</param>
        /// <param name="key">Keyword for product name. Default is null.</param>
        /// <param name="onlyFavorite">Get only favorited items. Default is false.</param>
        /// <param name="onlyFeatured">Get only featured items. Default is false.</param>
        /// <param name="onlyPopular">Get only popular items. Default is false.</param>
        /// <returns>List of product filtered by parameters</returns>
        Task<IEnumerable<Item>> GetItemsAsync(string categoriId = null, string key = null,
                                              bool onlyFavorite = false, bool onlyFeatured = false,
                                              bool onlyPopular = false, bool onlySale = false);

        /// <summary>
        /// Get categories by name
        /// </summary>
        /// <param name="name">Keyword for category name</param>
        /// <returns>List of categories filtered by name</returns>
        Task<IEnumerable<Category>> GetCategoriesAsync(string name);

        /// <summary>
        /// Get list of all banners
        /// </summary>
        /// <returns>List of banner objects</returns>
        Task<IEnumerable<Banner>> GetBannersAsync();

        /// <summary>
        /// Get customer by id
        /// </summary>
        /// <param name="id">Customer Id</param>
        /// <returns>Customer object or null</returns>
        Task<Customer> GetCustomerAsync(string id);

        /// <summary>
        /// Get cart item by id
        /// </summary>
        /// <param name="id">CartItem id</param>
        /// <returns>CartItem object or null</returns>
        Task<BasketItem> GetCartItemAsync(string id);

        /// <summary>
        /// Add the cart item
        /// </summary>
        /// <param name="cartItem">CartItem object</param>
        /// <returns>Added cart item</returns>
        Task<BasketItem> AddCartItemAsync(BasketItem cartItem);

        /// <summary>
        /// Update the CartItem
        /// </summary>
        /// <param name="cartItem">CartItem object</param>
        /// <returns>True, if successful</returns>
        Task<bool> UpdateCartItemAsync(BasketItem cartItem);

        /// <summary>
        /// Get all items in the cart
        /// </summary>
        /// <returns>All CartItems in the cart</returns>
        Task<IEnumerable<BasketItem>> GetCartItemsAsync();

        /// <summary>
        /// Delete cart by id
        /// </summary>
        /// <param name="id">CartItem id</param>
        /// <returns>True, if successful</returns>
        Task<bool> DeleteCartItemAsync(string id);

        /// <summary>
        /// Delete all items in the cart
        /// </summary>
        /// <returns>True, if successful</returns>
        Task<bool> DeleteAllCartItemsAsync();

        /// <summary>
        /// Add the favorite
        /// </summary>
        /// <param name="favorite">Favorite object</param>
        /// <returns>Added favorite object</returns>
        Task<Favorite> AddFavoriteAsync(Favorite favorite);

        /// <summary>
        /// Delete the Favorite
        /// </summary>
        /// <param name="id">Favorite id</param>
        /// <returns>True, if successful</returns>
        Task<bool> DeleteFavoriteAsync(string id);

        /// <summary>
        /// Determine the product is favorite 
        /// </summary>
        /// <param name="customerId">Customer id</param>
        /// <param name="productId">Product id</param>
        /// <returns>True, if product has been addes to favorites for customer</returns>
        Task<bool> IsFavoriteAsync(string customerId, string productId);

        /// <summary>
        /// Get the Favorite object by parameters
        /// </summary>
        /// <param name="customerId">Customer id</param>
        /// <param name="productId">Product id</param>
        /// <returns>Favorite object or null</returns>
        Task<Favorite> GetFavoriteAsync(string customerId, string productId);

    }
}
