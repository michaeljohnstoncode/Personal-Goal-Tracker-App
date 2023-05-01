using BlazorBootstrap;
using TrainingProgressionApp.Data;
using TrainingProgressionApp.Pages.GoalCalendar;

namespace TrainingProgressionApp;

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
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		
        builder.Services.AddSingleton<Goal>();
		builder.Services.AddSingleton<GoalDatabase>();
		builder.Services.AddSingleton<GoalCalendar>();
		builder.Services.AddBlazorBootstrap();

		return builder.Build();
	}
}
