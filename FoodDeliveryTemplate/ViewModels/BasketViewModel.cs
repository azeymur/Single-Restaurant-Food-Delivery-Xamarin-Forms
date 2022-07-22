using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using FoodDeliveryTemplate.Services;
using FoodDeliveryTemplate.Resources;
using FoodDeliveryTemplate.Views;

namespace FoodDeliveryTemplate.ViewModels
{
    public class BasketViewModel : BaseViewModel
    {
        IService service => DependencyService.Get<IService>();

        public ObservableCollection<BasketItemViewModel> Items { get; }

        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command RemoveItemCommand { get; }
        public Command DeleteItemCommand { get; }
        public Command DeleteAllCommand { get; }
        public Command CheckoutCommand { get; }

        public double Total
        {
            get
            {
                double total = 0.0;

                foreach (var item in Items)
                    total += item.Total;

                return total;
            }
        }

        public BasketViewModel()
        {
            Title = AppResources.ShoppingBasket;

            Items = new ObservableCollection<BasketItemViewModel>();
            Items.CollectionChanged += (_, __) => OnPropertyChanged(nameof(Total));

            LoadItemsCommand = new Command(async () => await LoadItems());
            AddItemCommand = new Command<BasketItemViewModel>(OnAddItemTapped);
            RemoveItemCommand = new Command<BasketItemViewModel>(OnRemoveItemTapped);
            DeleteItemCommand = new Command<BasketItemViewModel>(OnDeleteItemTapped);
            DeleteAllCommand = new Command(OnDeleteAllTapped);
            CheckoutCommand = new Command(() => { });
        }

        async Task LoadItems()
        {
            IsBusy = true;

            Items.Clear();
            var items = await service.GetCartItemsAsync();
            foreach (var item in items)
            {
                Items.Add(new BasketItemViewModel(item));
            }

            IsBusy = false;
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        
        private async void OnAddItemTapped(BasketItemViewModel item)
        {
            item.Quantity += 1;

            var line = await service.GetCartItemAsync(item.Id);
            line.Quantity = item.Quantity;
            await service.UpdateCartItemAsync(line);

            OnPropertyChanged(nameof(Total));
        }

        private async void OnRemoveItemTapped(BasketItemViewModel item)
        {
            if (item.Quantity > 1)
            {
                item.Quantity -= 1;
                (await service.GetCartItemAsync(item.Id)).Quantity = item.Quantity;

                OnPropertyChanged(nameof(Total));
            }
            else
                OnDeleteItemTapped(item);
        }

        private async void OnDeleteItemTapped(BasketItemViewModel item)
        {
            Items.Remove(item);
            await service.DeleteCartItemAsync(item.Id);
        }

        private async void OnDeleteAllTapped()
        {
            var yesNo = await Shell.Current.DisplayAlert(AppResources.Question,
                            AppResources.DoYouWantDeleteAllItems, AppResources.Yes, AppResources.No);

            if (yesNo == false) return;

            Items.Clear();
            await service.DeleteAllCartItemsAsync();
        }

    }
}
