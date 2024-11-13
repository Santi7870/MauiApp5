namespace MauiApp5;

public partial class StackLayoutPage : ContentPage
{
    public StackLayoutPage()
    {
        InitializeComponent();
    }

    private async void OnNavigateToFlexLayoutPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FlexLayoutPage());
    }

}