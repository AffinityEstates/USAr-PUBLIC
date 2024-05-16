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

#if DEBUG
    		builder.Logging.AddDebug();
            builder.Services.AddSingleton<RecordDetailPage>();
            builder.Services.AddSingleton<UserDetailViewModel>();

            builder.Services.AddTransient<DroneDetailPage>();
            builder.Services.AddTransient<DroneDetailVM>();
#endif

            return builder.Build();
        }
    }
}
