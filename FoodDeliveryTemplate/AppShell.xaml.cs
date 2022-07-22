using System;
using System.Collections.Generic;
using FoodDeliveryTemplate.ViewModels;
using FoodDeliveryTemplate.Views;
using Xamarin.Forms;

namespace FoodDeliveryTemplate
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MyAccountPage), typeof(MyAccountPage));
        }

    }
}
