using System;
using System.Collections.Generic;

namespace FoodDeliveryTemplate.Models
{
    public class MenuCategory : List<MenuItem>
    {
        public string Name { get; private set; }

        public MenuCategory(string name, List<MenuItem> items) : base(items)
        {
            Name = name;
        }
    }
}
