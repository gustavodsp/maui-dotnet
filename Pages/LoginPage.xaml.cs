using System.Net.Mime;

namespace MauiDotnet.Pages;

public partial class LoginPage : ContentPage
{

    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnRetryClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Pages.InstallPage));
    }

}