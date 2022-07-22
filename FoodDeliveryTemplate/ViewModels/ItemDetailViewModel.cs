using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FoodDeliveryTemplate.Models;
using FoodDeliveryTemplate.Services;
using Xamarin.Forms;

namespace FoodDeliveryTemplate.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        IService service = DependencyService.Get<IService>();

        public Command FavoriteCommand { get; }
        public Command CloseCommand { get; }
        public Command<ChoiceItem> ChoiceItemCommand { get; }
        public Command AddBasketCommand { get; }
        public Command AddCommand { get; }
        public Command RemoveCommand { get; }

        private string name;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        private string image;
        public string Image
        {
            get => image;
            set => SetProperty(ref image, value);
        }

        private bool isFavorite;
        public bool IsFavorite
        {
            get => isFavorite;
            set => SetProperty(ref isFavorite, value);
        }

        public float Price
        {
            get
            {
                float p = item.Price;

                foreach (var choice in item.Choices)
                    foreach (var i in choice)
                        if (i is OptionItem && i.IsSelected)
                            p += ((OptionItem)i).Price;
                        else if (i is ExtraItem && i.IsSelected)
                            p += ((ExtraItem)i).Price;

                return p;
            }
        }

        private int quantity;
        public int Quantity
        {
            get => quantity;
            set => SetProperty(ref quantity, value);
        }

        private List<Choice<ChoiceItem>> choices;
        public List<Choice<ChoiceItem>> Choices
        {
            get => choices;
            set => SetProperty(ref choices, value);
        }

        private Item item;

        public ItemDetailViewModel(Item item)
        {
            this.item = item;

            Name = item.Name;
            Image = item.Image;
            Choices = item.Choices;
            IsFavorite = item.IsFavorite;
            Quantity = 1;

            foreach (var choice in item.Choices)
                foreach (var i in choice)
                    if (i is IngredientItem)
                    {
                        i.IsSelected = false;
                    }
                    else if (i is OptionItem)
                    {
                        if ((i as OptionItem).IsDefault) i.IsSelected = true; else i.IsSelected = false;
                    }
                    else if (i is ExtraItem)
                    {
                        if ((i as ExtraItem).IsDefault) i.IsSelected = true; else i.IsSelected = false;
                    }

            FavoriteCommand = new Command(OnFavoriteTapped);

            CloseCommand = new Command(async () => await Shell.Current.Navigation.PopModalAsync());

            ChoiceItemCommand = new Command<ChoiceItem>(OnChoiceItemTapped);

            AddBasketCommand = new Command(OnAddBasketTapped);

            AddCommand = new Command(() => { Quantity += 1; });

            RemoveCommand = new Command(() => { if (Quantity > 1) Quantity -= 1; });
        }

        async void OnFavoriteTapped()
        {
            var fav = await service.GetFavoriteAsync(Globals.LoggedCustomerId, item.Id);

            if (fav != null)
            {
                await service.DeleteFavoriteAsync(fav.Id);

                await Task.Delay(300);
                IsFavorite = false;
            }
            else
            {
                await service.AddFavoriteAsync(new Favorite
                {
                    Id = Guid.NewGuid().ToString(),
                    CustomerId = Globals.LoggedCustomerId,
                    ItemId = item.Id
                });

                IsFavorite = true;
            }
        }

        void OnChoiceItemTapped(ChoiceItem choiceItem)
        {
            if (choiceItem is IngredientItem)
            {
                choiceItem.IsSelected = !choiceItem.IsSelected;
            }
            else if (choiceItem is OptionItem)
            {
                foreach (var i in ((OptionItem)choiceItem).choice)
                    i.IsSelected = false;

                choiceItem.IsSelected = true;

                OnPropertyChanged(nameof(Price));
            }
            else if (choiceItem is ExtraItem)
            {
                choiceItem.IsSelected = !choiceItem.IsSelected;

                OnPropertyChanged(nameof(Price));
            }
        }

        async void OnAddBasketTapped()
        {
            var ingredientBuilder = new StringBuilder();
            var choicesBuilder = new StringBuilder();
            

            foreach (var i in item.Choices)
            {
                ingredientBuilder.Append(i.ToIngredientString());
                choicesBuilder.Append(i.ToString());
            }

            if (ingredientBuilder.Length > 2) ingredientBuilder.Remove(ingredientBuilder.Length - 3, 3);
            if (choicesBuilder.Length > 2) choicesBuilder.Remove(choicesBuilder.Length - 3, 3);

            await service.AddCartItemAsync(new BasketItem
            {
                Id = Guid.NewGuid().ToString(),
                ProductName = item.Name,
                ProductImage = item.Image,
                UnitPrice = Price,
                Quantity = Quantity,
                IngredientString = ingredientBuilder.ToString(),
                ChoiceString = choicesBuilder.ToString()
            });

            await Shell.Current.Navigation.PopModalAsync();
        }
    }
}
