using Microsoft.Maui.Controls;

namespace MauiApp5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNavigateToStackLayoutPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayoutPage());
        }
    }

}
