namespace MauiApp5
{
    public partial class AbsoluteLayoutPage : ContentPage
    {
        public AbsoluteLayoutPage()
        {
            InitializeComponent();
        }

        // Maneja el clic del botón
        private async void OnGoToGridLayoutClicked(object sender, EventArgs e)
        {
            // Redirige a la página GridLayout
            await Navigation.PushAsync(new GridLayautPage());
        }
    }
}