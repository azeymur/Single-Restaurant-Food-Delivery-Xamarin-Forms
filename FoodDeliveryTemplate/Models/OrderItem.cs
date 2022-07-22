using System;

namespace FoodDeliveryTemplate.Models
{
    /// <summary>
    /// Type represent item entity of the order
    /// </summary>
    public class OrderItem : Entity
    {
        /// <summary>
        /// The id of the associated order
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// The id of the associated product
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// The name of the associated product
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// The image of the associated product
        /// </summary>
        public string ProductImage { get; set; }

        /// <summary>
        /// Description of the associated product
        /// </summary>
        public string ProductDescription { get; set; }

        /// <summary>
        /// The unit price of the associated product on the order date
        /// </summary>
        public float UnitPrice { get; set; }

        /// <summary>
        /// Order amount
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Selected choices ready to be displayed
        /// </summary>
        public string IngredientString { get; set; }

        /// <summary>
        /// Selected choices ready to be displayed
        /// </summary>
        public string ChoiceString { get; set; }

        /// <summary>
        /// Calculated field: unit price x quantity
        /// </summary>
        public double Total
        {
            get { return Math.Round(UnitPrice * Quantity, 2); }
        }
    }
}
