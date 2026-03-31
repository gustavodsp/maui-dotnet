namespace MauiDotnet.Pages;

public partial class InstallPage : ContentPage
{
    
    private readonly IPrinterInstaller _installer;

    public InstallPage(IPrinterInstaller installer)
    {
        InitializeComponent();
        _installer = installer;
    }

    private async void OnInstallClicked(object sender, EventArgs e)
    {
        await _installer.InstallPrinterAsync();
        await DisplayAlert("Success", "Printer Installed", "OK");
    }

}