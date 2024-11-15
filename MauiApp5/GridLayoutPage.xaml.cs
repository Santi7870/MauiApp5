using Microsoft.Maui.Controls;

namespace MauiApp5
{
    public partial class GridLayautPage : ContentPage
    {
        public GridLayautPage()
        {
            InitializeComponent();
        }

        private async void OnNavigateToStackLayoutPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayoutPage());
        }
    }

}
