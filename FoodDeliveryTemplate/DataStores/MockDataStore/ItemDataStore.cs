using System.Collections.Generic;
using FoodDeliveryTemplate.Models;

namespace FoodDeliveryTemplate.DataStores.MockDataStore
{
    public class ItemDataStore : BaseDataStore<Item>, IItemDataStore
    {
        protected override IList<Item> items { get; }

        public ItemDataStore()
        {
            items = new List<Item>
            {
                // menu

                new Item
                {
                    Id = "i001",
                    Name = "Classic Burger Menu",
                    Description = "Burger, Potato, Beverage",
                    Image = "mi_classic_burger_menu",
                    Price = 18,
                    CategoryId = "c001",
                    Choices = new List<Choice<ChoiceItem>>
                    {
                        new Choice<ChoiceItem>("Ingredients", new List<ChoiceItem>
                        {
                            new IngredientItem("Onion"),
                            new IngredientItem("Pickles"),
                            new IngredientItem("Tomato"),
                            new IngredientItem("Mayonnaise"),
                            new IngredientItem("Lettuce")
                        }),

                        new Choice<ChoiceItem>("Hamburger Bread", new List<ChoiceItem>
                        {
                            new OptionItem("Classic", 0f, true),
                            new OptionItem("Bread with Sesame", 1f)
                        }),

                        new Choice<ChoiceItem>("Potato", new List<ChoiceItem>
                        {
                            new OptionItem("Apple slice", 0f, true),
                            new OptionItem("Finger")
                        }),

                        new Choice<ChoiceItem>("Beverage", new List<ChoiceItem>
                        {
                            new OptionItem("Cola 33cl", 0f, true),
                            new OptionItem("Sprite 33cl"),
                            new OptionItem("Fanta 33cl"),
                            new OptionItem("Fruko 33cl"),
                            new OptionItem("Cappy 33cl"),
                            new OptionItem("7up 33cl")
                        })
                    }
                },

                new Item
                {
                    Id = "i002",
                    Name = "Classic Double Burger Menu",
                    Description = "Burger, Potato, Beverage",
                    Image = "mi_double_burger_menu",
                    Price = 32,
                    RegularPrice = 38,
                    IsFeatured = true,
                    CategoryId = "c001",
                    Choices = new List<Choice<ChoiceItem>>
                    {
                        new Choice<ChoiceItem>("Ingredients", new List<ChoiceItem>
                        {
                            new IngredientItem("Onion"),
                            new IngredientItem("Pickles"),
                            new IngredientItem("Tomato"),
                            new IngredientItem("Mayonnaise"),
                            new IngredientItem("Lettuce")
                        }),

                        new Choice<ChoiceItem>("Hamburger Bread", new List<ChoiceItem>
                        {
                            new OptionItem("Classic", 0f, true),
                            new OptionItem("Bread with Sesame", 1f)
                        }),

                        new Choice<ChoiceItem>("Potato", new List<ChoiceItem>
                        {
                            new OptionItem("Apple slice", 0f, true),
                            new OptionItem("Finger")
                        }),

                        new Choice<ChoiceItem>("Beverage", new List<ChoiceItem>
                        {
                            new OptionItem("Cola 33cl", 0f, true),
                            new OptionItem("Sprite 33cl"),
                            new OptionItem("Fanta 33cl"),
                            new OptionItem("Fruko 33cl"),
                            new OptionItem("Cappy 33cl"),
                            new OptionItem("7up 33cl")
                        })
                    }
                },

                new Item
                {
                    Id = "i003",
                    Name = "Chicken Burger Menu",
                    Description = "Chicken, bread, mayonnaise, lettuce",
                    Image = "mi_chicken_burger_menu",
                    Price = 12,
                    CategoryId = "c001",
                    Choices = new List<Choice<ChoiceItem>>
                    {
                        new Choice<ChoiceItem>("Ingredients", new List<ChoiceItem>
                        {
                            new IngredientItem("Mayonnaise"),
                            new IngredientItem("Lettuce")
                        }),

                        new Choice<ChoiceItem>("Hamburger Bread", new List<ChoiceItem>
                        {
                            new OptionItem("Classic", 0f, true),
                            new OptionItem("Bread with Sesame", 1f)
                        }),

                        new Choice<ChoiceItem>("Potato", new List<ChoiceItem>
                        {
                            new OptionItem("Apple slice", 0f, true),
                            new OptionItem("Finger")
                        }),

                        new Choice<ChoiceItem>("Beverage", new List<ChoiceItem>
                        {
                            new OptionItem("Cola 33cl", 0f, true),
                            new OptionItem("Sprite 33cl"),
                            new OptionItem("Fanta 33cl"),
                            new OptionItem("Fruko 33cl"),
                            new OptionItem("Cappy 33cl"),
                            new OptionItem("7up 33cl")
                        })
                    }
                },

                new Item
                {
                    Id = "i004",
                    Name = "Double Chicken Burger Menu",
                    Description = "Chicken, bread, mayonnaise, lettuce",
                    Image = "mi_double_chicken_burger_menu",
                    Price = 20,
                    CategoryId = "c001",
                    Choices = new List<Choice<ChoiceItem>>
                    {
                        new Choice<ChoiceItem>("Ingredients", new List<ChoiceItem>
                        {
                            new IngredientItem("Mayonnaise"),
                            new IngredientItem("Lettuce")
                        }),

                        new Choice<ChoiceItem>("Hamburger Bread", new List<ChoiceItem>
                        {
                            new OptionItem("Classic", 0f, true),
                            new OptionItem("Bread with Sesame", 1f)
                        }),

                        new Choice<ChoiceItem>("Potato", new List<ChoiceItem>
                        {
                            new OptionItem("Apple slice", 0f, true),
                            new OptionItem("Finger")
                        }),

                        new Choice<ChoiceItem>("Beverage", new List<ChoiceItem>
                        {
                            new OptionItem("Cola 33cl", 0f, true),
                            new OptionItem("Sprite 33cl"),
                            new OptionItem("Fanta 33cl"),
                            new OptionItem("Fruko 33cl"),
                            new OptionItem("Cappy 33cl"),
                            new OptionItem("7up 33cl")
                        })
                    }
                },

                // burger

                new Item
                {
                    Id = "i005",
                    Name = "Classic Burger",
                    Description = "Beef, bread, pickles, ketchup, mayonnaise, lettuce, tomato, onion.",
                    Image = "mi_burger",
                    Price = 8,
                    RegularPrice = 10,
                    CategoryId = "c002",
                    Choices = new List<Choice<ChoiceItem>>
                    {
                        new Choice<ChoiceItem>("Ingredients", new List<ChoiceItem>
                        {
                            new IngredientItem("Onion"),
                            new IngredientItem("Pickles"),
                            new IngredientItem("Tomato"),
                            new IngredientItem("Mayonnaise"),
                            new IngredientItem("Lettuce")
                        }),

                        new Choice<ChoiceItem>("Hamburger Bread", new List<ChoiceItem>
                        {
                            new OptionItem("Classic", 0f, true),
                            new OptionItem("Bread with Sesame", 1f)
                        })
                    }
                },

                new Item
                {
                    Id = "i006",
                    Name = "Double Burger",
                    Description = "Beef, bread, pickles, ketchup, mayonnaise, lettuce, tomato, onion.",
                    Image = "mi_double_burger",
                    Price = 14,
                    CategoryId = "c002",
                    Choices = new List<Choice<ChoiceItem>>
                    {
                        new Choice<ChoiceItem>("Ingredients", new List<ChoiceItem>
                        {
                            new IngredientItem("Onion"),
                            new IngredientItem("Pickles"),
                            new IngredientItem("Tomato"),
                            new IngredientItem("Mayonnaise"),
                            new IngredientItem("Lettuce")
                        }),

                        new Choice<ChoiceItem>("Hamburger Bread", new List<ChoiceItem>
                        {
                            new OptionItem("Classic", 0f, true),
                            new OptionItem("Bread with Sesame", 1f)
                        })
                    }
                },

                new Item
                {
                    Id = "i007",
                    Name = "Chicken Burger",
                    Description = "Chicken, bread, mayonnaise, lettuce",
                    Image = "mi_chicken_burger",
                    Price = 6,
                    CategoryId = "c002",
                    Choices = new List<Choice<ChoiceItem>>
                    {
                        new Choice<ChoiceItem>("Ingredients", new List<ChoiceItem>
                        {
                            new IngredientItem("Mayonnaise"),
                            new IngredientItem("Lettuce")
                        }),

                        new Choice<ChoiceItem>("Hamburger Bread", new List<ChoiceItem>
                        {
                            new OptionItem("Classic", 0f, true),
                            new OptionItem("Bread with Sesame", 1f)
                        })
                    }
                },

                new Item
                {
                    Id = "i008",
                    Name = "Double Chicken Burger",
                    Description = "Chicken, bread, mayonnaise, lettuce.",
                    Image = "mi_double_chicken_burger",
                    Price = 10,
                    CategoryId = "c002",
                    Choices = new List<Choice<ChoiceItem>>
                    {
                        new Choice<ChoiceItem>("Ingredients", new List<ChoiceItem>
                        {
                            new IngredientItem("Mayonnaise"),
                            new IngredientItem("Lettuce")
                        }),

                        new Choice<ChoiceItem>("Hamburger Bread", new List<ChoiceItem>
                        {
                            new OptionItem("Classic", 0f, true),
                            new OptionItem("Bread with Sesame", 1f)
                        })
                    }
                },

                // meat

                new Item
                {
                    Id = "i009",
                    Name = "Tenderloin",
                    Description = "Tenderloin, salad, pasta.",
                    Image = "mi_tenderloin",
                    Price = 20,
                    IsPopular = true,
                    CategoryId = "c003",
                    Choices = new List<Choice<ChoiceItem>>
                    {
                        new Choice<ChoiceItem>("Sauces", new List<ChoiceItem>
                        {
                            new ExtraItem("Barbeque", 2f),
                            new ExtraItem("Ranch", 2f),
                            new ExtraItem("Garlic", 2f),
                            new ExtraItem("Mustrad", 2f),
                            new ExtraItem("Cheddar", 2f),
                            new ExtraItem("Chili", 2f)
                        })
                    }
                },

                new Item
                {
                    Id = "i010",
                    Name = "Tenderloin with Mushroom Sauce",
                    Description = "Tenderloin, mushroom sauce, salad, pasta.",
                    Image = "mi_tenderloin_mushroom",
                    Price = 23,
                    CategoryId = "c003",
                    Choices = new List<Choice<ChoiceItem>>
                    {
                        new Choice<ChoiceItem>("Sauces", new List<ChoiceItem>
                        {
                            new ExtraItem("Barbeque", 2f),
                            new ExtraItem("Ranch", 2f),
                            new ExtraItem("Garlic", 2f),
                            new ExtraItem("Mustrad", 2f),
                            new ExtraItem("Cheddar", 2f),
                            new ExtraItem("Chili", 2f)
                        })
                    }
                },

                new Item
                {
                    Id = "i011",
                    Name = "Grilled Meatball",
                    Description = "Grilled meatball, salad, potato.",
                    Image = "mi_meatball",
                    Price = 25,
                    IsFeatured = true,
                    CategoryId = "c003",
                    Choices = new List<Choice<ChoiceItem>>
                    {
                        new Choice<ChoiceItem>("Sauces", new List<ChoiceItem>
                        {
                            new ExtraItem("Barbeque", 2f),
                            new ExtraItem("Ranch", 2f),
                            new ExtraItem("Garlic", 2f),
                            new ExtraItem("Mustrad", 2f),
                            new ExtraItem("Cheddar", 2f),
                            new ExtraItem("Chili", 2f)
                        })
                    }
                },

                // chicken

                new Item
                {
                    Id = "i012",
                    Name = "Grilled Chicken Steak",
                    Description = "Grilled chicken steak, pasta, salad",
                    Image = "mi_grilled_chicken_steak",
                    Price = 16,
                    CategoryId = "c004",
                    Choices = new List<Choice<ChoiceItem>>
                    {
                        new Choice<ChoiceItem>("Extra Ingredients", new List<ChoiceItem>
                        {
                            new ExtraItem("Mushroom", 3f),
                            new ExtraItem("Special Sauce", 2f)
                        })
                    }
                },

                new Item
                {
                    Id = "i014",
                    Name = "Alinazik Chicken",
                    Description = "Chicken chop, yogurt, eggplant",
                    Image = "mi_alinazik_chicken",
                    Price = 20,
                    IsFeatured = true,
                    CategoryId = "c004",
                    Choices = new List<Choice<ChoiceItem>>
                    {
                        new Choice<ChoiceItem>("Extra Ingredients", new List<ChoiceItem>
                        {
                            new ExtraItem("Mushroom", 3f),
                            new ExtraItem("Special Sauce", 2f)
                        })
                    }
                },

                new Item
                {
                    Id = "i015",
                    Name = "Chicken with curry sauce",
                    Description = "Chicken curry sauce, mushroom, pasta, onion, salad",
                    Image = "mi_curry_chicken",
                    Price = 22,
                    IsPopular = true,
                    CategoryId = "c004",
                    Choices = new List<Choice<ChoiceItem>>
                    {
                        new Choice<ChoiceItem>("Extra Ingredients", new List<ChoiceItem>
                        {
                            new ExtraItem("Mushroom", 3f),
                            new ExtraItem("Special Sauce", 2f)
                        })
                    }
                },

                new Item
                {
                    Id = "i016",
                    Name = "Chicken Fajitas",
                    Description = "Chicken fajitas, mushroom, onion, salad, pepper",
                    Image = "mi_chicken_fajitas",
                    Price = 22,
                    CategoryId = "c004",
                    Choices = new List<Choice<ChoiceItem>>
                    {
                        new Choice<ChoiceItem>("Ingredients", new List<ChoiceItem>
                        {
                            new IngredientItem("Onion"),
                            new IngredientItem("Pepper")
                        }),

                        new Choice<ChoiceItem>("Potato", new List<ChoiceItem>
                        {
                            new OptionItem("Apple slice", 0f, true),
                            new OptionItem("Finger")
                        }),

                        new Choice<ChoiceItem>("Extra Ingredients", new List<ChoiceItem>
                        {
                            new ExtraItem("Mushroom", 3f),
                            new ExtraItem("Special Sauce", 2f)
                        })
                    }
                },

                // pasta

                new Item
                {
                    Id = "i017",
                    Name = "Noodle Chicken",
                    Description = "Chicken with sauce, mushroom, pepper",
                    Image = "mi_noodle_chicken",
                    Price = 10,
                    RegularPrice = 12,
                    CategoryId = "c005",
                    Choices = new List<Choice<ChoiceItem>>
                    {
                        new Choice<ChoiceItem>("Ingredients", new List<ChoiceItem>
                        {
                            new IngredientItem("Pepper")
                        })
                    }
                },

                new Item
                {
                    Id = "i018",
                    Name = "Spaghetti Bolognese",
                    Description = "Tomato sauce, mince, pasta",
                    Image = "mi_spaghetti_bolognese",
                    Price = 10,
                    IsFeatured = true,
                    CategoryId = "c005",
                    Choices = new List<Choice<ChoiceItem>>()
                },

                new Item
                {
                    Id = "i019",
                    Name = "Napolitan Pasta",
                    Description = "Napolitan sauce, cheddar, pasta",
                    Image = "mi_napolitan_pasta",
                    Price = 11,
                    RegularPrice = 12,
                    IsPopular = true,
                    CategoryId = "c005",
                    Choices = new List<Choice<ChoiceItem>>()
                },

                new Item
                {
                    Id = "i020",
                    Name = "Alfredo Pasta",
                    Description = "Chicken with sauce, cheddar, mushroom, pasta, custard",
                    Image = "mi_alfredo_pasta",
                    Price = 12,
                    RegularPrice = 14f,
                    IsFeatured = true,
                    CategoryId = "c005",
                    Choices = new List<Choice<ChoiceItem>>()
                },

                // salad

                new Item
                {
                    Id = "i021",
                    Name = "Caesar Salad",
                    Description = "Chicken fillet, cucumber, tomato, lettuce, caesar sauce.",
                    Image = "mi_caesar_salad",
                    Price = 7,
                    RegularPrice = 8,
                    CategoryId = "c006",
                    Choices = new List<Choice<ChoiceItem>>()
                },

                new Item
                {
                    Id = "i022",
                    Name = "Mexican Salad",
                    Description = "Chicken with Mexican sauce, cucumber, tomato, corn, lettuce.",
                    Image = "mi_mexican_salad",
                    Price = 8,
                    IsPopular = true,
                    CategoryId = "c006",
                    Choices = new List<Choice<ChoiceItem>>()
                },

                new Item
                {
                    Id = "i023",
                    Name = "Thai Salad",
                    Description = "Mushrooms in sauce, beans, lettuce, cucumber, tomato, corn.",
                    Image = "mi_thai_salad",
                    Price = 8,
                    CategoryId = "c006",
                    Choices = new List<Choice<ChoiceItem>>()
                },

                new Item
                {
                    Id = "i024",
                    Name = "Tuna Salad",
                    Description = "Mediterranean salad, tuna, tomato, cucumber, corn, lettuce.",
                    Image = "mi_tuna_salad",
                    Price = 10,
                    CategoryId = "c006",
                    Choices = new List<Choice<ChoiceItem>>()
                },

                // dessert

                new Item
                {
                    Id = "i025",
                    Name = "Ginger Carrot Cake",
                    Description = "Carrot cake with ginger",
                    Image = "mi_ginger_carrot_cake",
                    Price = 4,
                    CategoryId = "c007",
                    Choices = new List<Choice<ChoiceItem>>()
                },

                new Item
                {
                    Id = "i026",
                    Name = "Lemon Tart",
                    Description = "Pastry shell with a lemon flavored filling.",
                    Image = "mi_lemon_tart",
                    Price = 4,
                    RegularPrice = 6,
                    CategoryId = "c007",
                    Choices = new List<Choice<ChoiceItem>>()
                },

                new Item
                {
                    Id = "i027",
                    Name = "Profiterole",
                    Description = "Small hollow pastry typically filled with cream and covered with chocolate sauce.",
                    Image = "mi_profiterole",
                    Price = 5,
                    IsPopular = true,
                    CategoryId = "c007",
                    Choices = new List<Choice<ChoiceItem>>()
                },

                new Item
                {
                    Id = "i028",
                    Name = "Salted Caramel Brownie",
                    Description = "70% dark chocolate, salted caramel brownie.",
                    Image = "mi_salted_caramel_brownie",
                    Price = 5,
                    RegularPrice = 7,
                    CategoryId = "c007",
                    Choices = new List<Choice<ChoiceItem>>()
                },

                new Item
                {
                    Id = "i029",
                    Name = "Supangle",
                    Description = "Its bottom layer includes pieces of cake and it is often garnished with pistachio or coconut, and chocolate chips.",
                    Image = "mi_supangle",
                    Price = 5,
                    CategoryId = "c007",
                    Choices = new List<Choice<ChoiceItem>>()
                },

                // beverage

                new Item
                {
                    Id = "i030",
                    Name = "Caffe Latte",
                    Image = "mi_caffe_latte",
                    Price = 2,
                    RegularPrice = 3,
                    CategoryId = "c008",
                    Choices = new List<Choice<ChoiceItem>>()
                },

                new Item
                {
                    Id = "i031",
                    Name = "Cappucino",
                    Image = "mi_cappucino",
                    Price = 2,
                    CategoryId = "c008",
                    Choices = new List<Choice<ChoiceItem>>()
                },

                new Item
                {
                    Id = "i032",
                    Name = "Ice Americano",
                    Image = "mi_ice_americano",
                    Price = 3,
                    RegularPrice = 4f,
                    CategoryId = "c008",
                    Choices = new List<Choice<ChoiceItem>>()
                },

                new Item
                {
                    Id = "i033",
                    Name = "Americano",
                    Image = "mi_americano",
                    Price = 3,
                    RegularPrice = 4f,
                    CategoryId = "c008",
                    Choices = new List<Choice<ChoiceItem>>()
                }

            };

            foreach (var item in items)
                foreach (var choice in item.Choices)
                    foreach (var i in choice)
                        i.choice = choice;
        }
    }
}
