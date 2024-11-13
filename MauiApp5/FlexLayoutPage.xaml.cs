namespace MauiApp5
{
    public partial class FlexLayoutPage : ContentPage
    {
        public FlexLayoutPage()
        {
            InitializeComponent();
        }

        // Maneja el clic en la imagen
        private async void OnImageTapped(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteLayoutPage());
        }
    }
}
