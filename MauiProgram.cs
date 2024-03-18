using Microsoft.Extensions.Logging;
using TecnologicoApp.Services;

namespace TecnologicoApp
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

            ConfigureServices(builder.Services);

            return builder.Build();
        }

        static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ICalculatorService, CalculatorService>();
        }
    }
}