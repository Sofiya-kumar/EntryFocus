using Microsoft.Extensions.Logging;

namespace EntryFocus
{
    public static class MauiProgram
    {
        public static string SamplePage= "samplePage";
        public static string MainPage= "mainPage";
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            Routing.RegisterRoute(MainPage, typeof(MainPage));
            Routing.RegisterRoute(SamplePage, typeof(SamplePage));
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

            return builder.Build();
        }
    }
}
