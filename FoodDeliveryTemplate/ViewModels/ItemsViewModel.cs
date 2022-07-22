using System.Collections.ObjectModel;
using System.Threading.Tasks;
using FoodDeliveryTemplate.Models;
using FoodDeliveryTemplate.Resources;
using FoodDeliveryTemplate.Services;
using FoodDeliveryTemplate.Views;
using Xamarin.Forms;

namespace FoodDeliveryTemplate.ViewModels
{
    [QueryProperty(nameof(Title), nameof(Title))]
    [QueryProperty(nameof(CategoryId), nameof(CategoryId))]
    [QueryProperty(nameof(OnlyFeatured), nameof(OnlyFeatured))]
    [QueryProperty(nameof(OnlyFavorite), nameof(OnlyFavorite))]
    [QueryProperty(nameof(OnlyPopular), nameof(OnlyPopular))]
    [QueryProperty(nameof(OnlySale), nameof(OnlySale))]
    public class ItemsViewModel : BaseViewModel
    {
        IService service => DependencyService.Get<IService>();

        public ObservableCollection<Item> Items { get; }

        public Command LoadItemsCommand { get; }
        public Command<Item> ItemCommand { get; }

        private string categoryId;
        public string CategoryId
        {
            get => categoryId;
            set => categoryId = value;
        }

        private bool onlyFeatured;
        public bool OnlyFeatured
        {
            get => onlyFeatured;
            set => onlyFeatured = value;
        }

        private bool onlyPopular;
        public bool OnlyPopular
        {
            get => onlyPopular;
            set => onlyPopular = value;
        }

        private bool onlyFavorite;
        public bool OnlyFavorite
        {
            get => onlyFavorite;
            set => onlyFavorite = value;
        }

        private bool onlySale;
        public bool OnlySale
        {
            get => onlySale;
            set => onlySale = value;
        }

        public ItemsViewModel()
        {
            Title = AppResources.MenuItems;

            Items = new ObservableCollection<Item>();

            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            ItemCommand = new Command<Item>(async (item) =>
                await Shell.Current.Navigation.PushModalAsync(new ItemDetailPage(item)));
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            Items.Clear();
            var items = await service.GetItemsAsync(categoriId: categoryId,
                                                    onlyFavorite: OnlyFavorite,
                                                    onlyFeatured: OnlyFeatured,
                                                    onlyPopular: OnlyPopular,
                                                    onlySale: OnlySale);

            foreach (var item in items)
                Items.Add(item);

            IsBusy = false;
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }


    }
}
