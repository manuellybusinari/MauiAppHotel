using Microsoft.Extensions.Logging;

namespace MauiAppHotel
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
                    fonts.AddFont("Comfortaa-Bold.ttf", "ComfortaaBold");
                    fonts.AddFont("Comfortaa-Light.ttf", "ComfortaaLight");
                    fonts.AddFont("Comfortaa-Medium.ttf", "ComfortaaMedium");
                    fonts.AddFont("Comfortaa-Regular.ttf", "ComfortaaRegular");
                    fonts.AddFont("Comfortaa-SemiBold.ttf", "ComfortaaSemiBold");
                    fonts.AddFont("Comfortaa-Regular.ttf", "ComfortaaRegular");
                    fonts.AddFont("Oswald-Bold.ttf", "OswaldBold");
                    fonts.AddFont("Oswald-Medium.ttf", "OswalMedium");
                    fonts.AddFont("Oswald-Regular.ttf", "OswaldRegular");




                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
