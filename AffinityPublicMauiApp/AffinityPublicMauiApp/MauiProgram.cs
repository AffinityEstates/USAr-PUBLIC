using AffinityPublicMauiApp.Models.ViewModels;
using AffinityPublicMauiApp.Pages;
using Microsoft.Extensions.Logging;

namespace AffinityPublicMauiApp
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

            builder.Services.AddSingleton<RecordDetailPage>();
            builder.Services.AddSingleton<MainPageViewModel>();

            builder.Services.AddTransient<DroneDetailPage>();
            builder.Services.AddTransient<DroneDetailVM>();

#if DEBUG
            builder.Logging.AddDebug();
            
#endif

            return builder.Build();
        }
    }
}
