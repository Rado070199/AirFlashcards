using Microsoft.Extensions.Logging;

namespace AirFlashcards;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif

	        // Rejestracja ViewModels
        builder.Services.AddSingleton<HomeViewModel>();

        // Rejestracja Pages
        builder.Services.AddSingleton<HomeView>();

		return builder.Build();
	}
}
