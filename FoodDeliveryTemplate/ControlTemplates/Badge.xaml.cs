using Xamarin.Forms;

namespace FoodDeliveryTemplate.ControlTemplates
{
    /// <summary>
    /// Shows an icon in the middle of a framed circle with a gradient background.
    /// </summary>
    public partial class Badge : ContentView
    {
        public static readonly BindableProperty BadgeIconProperty =
            BindableProperty.Create(nameof(BadgeIcon), typeof(string), typeof(Badge), MaterialDesign.Icons.Image);

        /// <summary>
        /// The Unicode string of a material icon to be displayed in the badge.
        /// </summary>
        public string BadgeIcon
        {
            get => (string)GetValue(BadgeIconProperty);
            set => SetValue(BadgeIconProperty, value);
        }

        public Badge()
        {
            InitializeComponent();
        }
    }
}
