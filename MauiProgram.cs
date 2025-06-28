using Microsoft.Extensions.Logging;
using $safeprojectname$.ViewModels;
using $safeprojectname$.Views;
using $safeprojectname$.Services;

namespace $safeprojectname$
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

            // Register services
            builder.Services.AddSingleton<WeatherService>();
            builder.Services.AddSingleton<IGeolocation>(Geolocation.Default);

            // Register view models
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddTransient<CitySearchViewModel>();

            // Register pages
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<CitySearchPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}