namespace MauiApp5
{
    public partial class AbsoluteLayoutPage : ContentPage
    {
        public AbsoluteLayoutPage()
        {
            InitializeComponent();
        }

        // Maneja el clic del bot�n
        private async void OnGoToGridLayoutClicked(object sender, EventArgs e)
        {
            // Redirige a la p�gina GridLayout
            await Navigation.PushAsync(new GridLayautPage());
        }
    }
}