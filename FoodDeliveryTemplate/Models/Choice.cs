using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliveryTemplate.Models
{
    public class Choice<T> : List<T> where T : ChoiceItem
    {
        public string Name { get; set; }

        public Choice(string name, List<T> items) : base(items)
        {
            Name = name;
        }

        public string ToIngredientString()
        {
            var builder = new StringBuilder();

            using (var i = GetEnumerator())
                while (i.MoveNext())
                    if (i.Current is IngredientItem && i.Current.IsSelected)
                        builder.Append(i.Current.Name + " · ");

            return builder.ToString();
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            using (var i = GetEnumerator())
                while (i.MoveNext())
                    if (i.Current.IsSelected && (i.Current is OptionItem || i.Current is ExtraItem))
                        builder.Append(i.Current.Name + " · ");

            return builder.ToString();
        }
    }
}
