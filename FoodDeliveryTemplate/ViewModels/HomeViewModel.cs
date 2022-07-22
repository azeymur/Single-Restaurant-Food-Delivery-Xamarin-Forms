using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using FoodDeliveryTemplate.Models;
using Xamarin.Forms;
using FoodDeliveryTemplate.Services;
using FoodDeliveryTemplate.Views;

namespace FoodDeliveryTemplate.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        IService service = DependencyService.Get<IService>();

        public ObservableCollection<Banner> Banners { get; }
        public ObservableCollection<Category> Categories { get; }
        public ObservableCollection<Item> FeaturedItems { get; }
        public ObservableCollection<Item> FavoriteItems { get; }
        public ObservableCollection<Item> PopularItems { get; }

        public Command SeeAllFeaturedCommand { get; }
        public Command SeeAllPopularCommand { get; }
        public Command SeeAllFavoriteCommand { get; }
        public Command<Banner> BannerCommand { get; }
        public Command<Category> CategoryCommand { get; }
        public Command<Item> ItemCommand { get; }

        public Command LoadPageCommand { get; }

        public HomeViewModel()
        {
            Banners = new ObservableCollection<Banner>();
            Categories = new ObservableCollection<Category>();
            FeaturedItems = new ObservableCollection<Item>();
            FavoriteItems = new ObservableCollection<Item>();
            PopularItems = new ObservableCollection<Item>();

            SeeAllFeaturedCommand = new Command(() => { });

            SeeAllPopularCommand = new Command(() => { });

            SeeAllFavoriteCommand = new Command(() => { });

            LoadPageCommand = new Command(async () => await ExecuteLoadPageCommand());

            BannerCommand = new Command<Banner>((b) => { });

            CategoryCommand = new Command<Category>((c) => { });

            ItemCommand = new Command<Item>(async (item) =>
                await Shell.Current.Navigation.PushModalAsync(new ItemDetailPage(item)));
        }

        async Task ExecuteLoadPageCommand()
        {
            IsBusy = true;

            Banners.Clear();
            var banners = await service.GetBannersAsync();
            foreach (var item in banners)
                Banners.Add(item);

            Categories.Clear();
            var categories = await service.GetCategoriesAsync(null);
            foreach (var item in categories)
                Categories.Add(item);

            FeaturedItems.Clear();
            var featuredItems = await service.GetItemsAsync(onlyFeatured: true);
            foreach (var item in featuredItems)
                FeaturedItems.Add(item);

            FavoriteItems.Clear();
            var favoriteItems = await service.GetItemsAsync(onlyFavorite: true);
            foreach (var item in favoriteItems)
                FavoriteItems.Add(item);

            PopularItems.Clear();
            var popularItems = await service.GetItemsAsync(onlyPopular: true);
            foreach (var item in popularItems)
                PopularItems.Add(item);

            IsBusy = false;
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

    }
}
