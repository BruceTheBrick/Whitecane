using epj.RouteGenerator;

namespace WhiteCane.Samples;

[AutoRoutes("Page")]
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseWhiteCane()
            .RegisterServices()
            .RegisterPages()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
        
        return builder.Build();
    }

    private static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
    {
        builder.Services.AddTransient<ISemanticScreenReader>(_ => SemanticScreenReader.Default);

        return builder;
    }

    private static MauiAppBuilder RegisterPages(this MauiAppBuilder builder)
    {
        builder.Services.AddTransient<HomePage>();
        builder.Services.AddTransient<HomePageViewModel>();
        
        builder.Services.AddTransient<AccessibilityContentViewPage>();
        builder.Services.AddTransient<AccessibilityContentViewPageViewModel>();

        return builder;
    }
}