using System.Collections.Generic;
using FoodDeliveryTemplate.Models;

namespace FoodDeliveryTemplate.DataStores.MockDataStore
{
    public class CategoryDataStore : BaseDataStore<Category>, ICategoryDataStore
    {
        protected override IList<Category> items { get; }

        public CategoryDataStore()
        {
            items = new List<Category>
            {
                new Category { Id = "c001", Name = "Menu", Image = "cat_menu"},

                new Category { Id = "c002", Name = "Burger", Image = "cat_burger" },

                new Category { Id = "c003", Name = "Meat", Image = "cat_meat" },

                new Category { Id = "c004", Name = "Chicken", Image = "cat_chicken" },

                new Category { Id = "c005", Name = "Pasta", Image = "cat_pasta" },

                new Category { Id = "c006", Name = "Salad", Image = "cat_salad" },

                new Category { Id = "c007", Name = "Dessert", Image = "mi_supangle"},

                new Category { Id = "c008", Name = "Beverage", Image = "mi_cappucino" }

            };
        }
    }
}
