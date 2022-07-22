using System;
using System.Collections.Generic;
using FoodDeliveryTemplate.Models;
using FoodDeliveryTemplate.ViewModels;
using Xamarin.Forms;

namespace FoodDeliveryTemplate.Views
{
    public partial class ItemDetailPage : ContentPage
    {

        public ItemDetailPage(Item item)
        {
            InitializeComponent();

            BindingContext = new ItemDetailViewModel(item);
        }
    }
}
