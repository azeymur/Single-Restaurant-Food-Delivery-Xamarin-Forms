using System;
using System.Text;

namespace FoodDeliveryTemplate.Models
{
    /// <summary>
    /// Type represent address entity
    /// </summary>
    public class Address : Entity
    {
        /// <summary>
        /// ID of the associated customer
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// Title for the address
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Receiver's first name for the address
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Receiver's last name for the address
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Company name for the address
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// Line 1 for the address
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Line 2 for the address
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// City name for the address
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// State name for the address
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Post code for the address
        /// </summary>
        public string PostCode { get; set; }

        /// <summary>
        /// Country name for the address
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// The phone number for the address
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Shortcut to display the address
        /// </summary>
        /// <returns>String ready to be displayed</returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(String.Format("{0} {1}", FirstName, LastName));
            if (!String.IsNullOrEmpty(Company)) builder.AppendLine(Company);
            builder.AppendLine(Address1);
            if (!String.IsNullOrEmpty(Address2)) builder.AppendLine(Address2);
            if (!String.IsNullOrEmpty(City)) builder.Append(City + " ");
            if (!String.IsNullOrEmpty(State)) builder.Append(State + " ");
            if (!String.IsNullOrEmpty(PostCode)) builder.Append(PostCode + " ");
            if (!String.IsNullOrEmpty(Country)) builder.Append(Country + " ");

            if (builder[builder.Length - 1] == ' ') builder.Remove(builder.Length - 1, 1);
            builder.AppendLine();

            if (!String.IsNullOrEmpty(Phone)) builder.AppendLine(Phone);
            if (builder[builder.Length - 1] == '\n') builder.Remove(builder.Length - 1, 1);

            return builder.ToString();
        }
    }
}
