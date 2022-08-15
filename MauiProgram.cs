using Carlist.App.Maui.Services;
using Carlist.App.Maui.ViewModels;
using Carlist.App.Maui.Views;

namespace Carlist.App.Maui;

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
		builder.Services.AddSingleton <CarService>();
        builder.Services.AddSingleton<CarListViewModel>();
        builder.Services.AddTransient<CarDetailsViewModel>();
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<CarDetailsPage>();


        return builder.Build();
	}
}
