namespace MauiApp5;

public partial class AbsoluteLayoutPage : ContentPage
{
    public AbsoluteLayoutPage()
    {
        InitializeComponent();
    }

    private async void OnNavigateToGridLayoutPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}