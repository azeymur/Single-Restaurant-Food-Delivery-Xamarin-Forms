using System.Collections.Generic;

namespace FoodDeliveryTemplate.Models
{
    public class Item : Entity
    {
        /// <summary>
        /// Name for the product
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description for the product
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Current price of the product
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// Regular price of the product
        /// </summary>
        public float RegularPrice { get; set; }

        /// <summary>
        /// True, if product is popular
        /// </summary>
        public bool IsPopular { get; set; }

        /// <summary>
        ///True, if prouct is featured
        /// </summary>
        public bool IsFeatured { get; set; }

        /// <summary>
        /// True if it is foverite item for the logged customer 
        /// </summary>
        public bool IsFavorite { get; set; }

        /// <summary>
        /// Image of the menu item
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Id of associated category
        /// </summary>
        public string CategoryId { get; set; }

        public List<Choice<ChoiceItem>> Choices { get; set; }


        public bool OnSale
        {
            get => RegularPrice != 0f;
        }
    }
}
