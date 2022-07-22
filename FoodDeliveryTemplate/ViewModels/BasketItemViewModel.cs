using System;
using FoodDeliveryTemplate.Models;

namespace FoodDeliveryTemplate.ViewModels
{
    public class BasketItemViewModel : BaseViewModel
    {
        private string id;
        public string Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }

        private string productId;
        public string ProductId
        {
            get => productId;
            set => SetProperty(ref productId, value);
        }

        private string productName;
        public string ProductName
        {
            get => productName;
            set => SetProperty(ref productName, value);
        }

        private string variantString;
        public string VariantString
        {
            get => variantString;
            set => SetProperty(ref variantString, value);
        }

        private string ingredientString;
        public string IngredientString
        {
            get => ingredientString;
            set => SetProperty(ref ingredientString, value);
        }

        private string choiceString;
        public string ChoiceString
        {
            get => choiceString;
            set => SetProperty(ref choiceString, value);
        }

        private string productDescription;
        public string ProductDescription
        {
            get => productDescription;
            set => SetProperty(ref productDescription, value);
        }

        private string productImage;
        public string ProductImage
        {
            get => productImage;
            set => SetProperty(ref productImage, value);
        }

        private float unitPrice;
        public float UnitPrice
        {
            get => unitPrice;
            set => SetProperty(ref unitPrice, value);
        }

        private int quantity;
        public int Quantity
        {
            get => quantity;
            set
            {
                SetProperty(ref quantity, value);
                OnPropertyChanged(nameof(Total));
            }
        }

        public double Total
        {
            get { return Math.Round(UnitPrice * Quantity, 2); }
        }

        public BasketItemViewModel(BasketItem item)
        {
            Id = item.Id;
            ProductId = item.ProductId;
            ProductName = item.ProductName;
            VariantString = item.VariantString;
            IngredientString = item.IngredientString;
            ChoiceString = item.ChoiceString;
            ProductDescription = item.ProductDescription;
            ProductImage = item.ProductImage;
            UnitPrice = item.UnitPrice;
            Quantity = item.Quantity;
        }

    }
}
