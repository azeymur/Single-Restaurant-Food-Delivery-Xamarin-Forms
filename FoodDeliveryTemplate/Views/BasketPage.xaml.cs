using FoodDeliveryTemplate.ViewModels;
using Xamarin.Forms;

namespace FoodDeliveryTemplate.Views
{
    public partial class BasketPage : ContentPage
    {
        BasketViewModel viewModel;

        public BasketPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new BasketViewModel();
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.OnAppearing();
        }

    }
}
