using Microsoft.AspNetCore.Components.WebView.Maui;
using TrainingProgressionApp.Data;
using TrainingProgressionApp.Services;

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
		
		builder.Services.AddSingleton<SampleEntryData>();
        builder.Services.AddSingleton<Goal>();
		builder.Services.AddSingleton<GoalDatabase>();

		return builder.Build();
	}
}
