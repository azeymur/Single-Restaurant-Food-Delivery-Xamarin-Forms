using System;

namespace FoodDeliveryTemplate.Models
{
    /// <summary>
    /// Type represent order entity
    /// </summary>
    public class Order : Entity
    {
        /// <summary>
        /// The id of the associated customer
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// The date of the order
        /// </summary>
        public DateTime DateGmt { get; set; }

        /// <summary>
        /// Billing address of the order
        /// </summary>
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Shipping address of the order
        /// </summary>
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// Shipping cost
        /// </summary>
        public double Shipping { get; set; }

        /// <summary>
        /// Sum of the lines in the order
        /// </summary>
        public double Total { get; set; }

        /// <summary>
        /// Items in the order
        /// </summary>
        public OrderItem[] Items { get; set; }

        /// <summary>
        /// State of the order
        /// </summary>
        public OrderStatus Status { get; set; }

        public DateTime PlacedTime { get; set; }

        public DateTime ProcessingTime { get; set; }

        public DateTime OnTheWayTime { get; set; }

        public DateTime DeliveredTime { get; set; }

        public DateTime CanceledTime { get; set; }

        /// <summary>
        /// Calculated field: shipping + total
        /// </summary>
        public double GrandTotal
        {
            get => Shipping + Total;
        }

    }
}
