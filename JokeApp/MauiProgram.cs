using Microsoft.Extensions.Logging;
using JokeApp.Services;
using JokeApp.Services.Interfaces;
using JokeApp.ViewModels;
using JokeApp.Views;


namespace JokeApp
{
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
            builder.Services.AddSingleton<IConfigurationService, ConfigurationService>();
            builder.Services.AddSingleton<IChuckNorrisApiService, ChuckNorrisApiHttpService>();
            builder.Services.AddSingleton<IPopUps, MauiPopupService>();

            builder.Services.AddTransient<JokesView>();
            builder.Services.AddTransient<JokesViewModel>();
            return builder.Build();
        }
    }
}
