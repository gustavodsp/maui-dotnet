using Microsoft.Extensions.Logging;
using MauiDotnet.Pages;

namespace MauiDotnet;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddTransient<WelcomePage>();
		builder.Services.AddTransient<LoginPage>();
		builder.Services.AddTransient<InstallPage>();

		#if WINDOWS
			builder.Services.AddSingleton<IPrinterInstaller, Platforms.Windows.Services.WindowsPrinterInstaller>();
		#endif

		#if DEBUG
			builder.Logging.AddDebug();
		#endif

		return builder.Build();
	}
}
