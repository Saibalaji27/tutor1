using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Syncfusion.Maui.Core.Hosting;
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

             builder.ConfigureSyncfusionCore();
            builder.UseMauiApp<App>().UseMauiCommunityToolkit();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<PrimeViewModel>();
            builder.Services.AddSingleton<StrongViewModel>();
            builder.Services.AddSingleton<OddEvenViewModel>();
            builder.Services.AddSingleton<PalindromeViewModel>();
            builder.Services.AddSingleton<PerfectViewModel>();
            builder.Services.AddSingleton<FactorialViewModel>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
