namespace MauiDotnet;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(Pages.InstallPage), typeof(Pages.InstallPage));
		Routing.RegisterRoute(nameof(Pages.LoginPage), typeof(Pages.LoginPage));
	}
}
