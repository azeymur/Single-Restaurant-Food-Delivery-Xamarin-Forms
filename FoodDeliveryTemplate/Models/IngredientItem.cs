using System;

namespace FoodDeliveryTemplate.Models
{
    public class IngredientItem : ChoiceItem
    {
        public bool IsRemoved { get; set; }

        public IngredientItem(string name) : base(name) { }
    }
}
