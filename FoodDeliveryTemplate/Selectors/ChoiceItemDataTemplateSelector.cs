using System;
using FoodDeliveryTemplate.Models;
using Xamarin.Forms;

namespace FoodDeliveryTemplate.Selectors
{
    public class ChoiceItemDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate IngredientTemplate { get; set; }
        public DataTemplate OptionTemplate { get; set; }
        public DataTemplate ExtraTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is IngredientItem) return IngredientTemplate;

            if (item is OptionItem) return OptionTemplate;

            return ExtraTemplate;
        }
    }
}
