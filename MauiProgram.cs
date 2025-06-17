using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using tutor.ViewModel;
namespace tutor
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
            builder.UseMauiApp<App>().UseMauiCommunityToolkit();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<PrimeViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
