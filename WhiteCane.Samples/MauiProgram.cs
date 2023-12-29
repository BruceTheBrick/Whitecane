using epj.RouteGenerator;
using WhiteCane.Samples.Features;

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
            .RegisterViewsAndViewModels()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
        
        return builder.Build();
    }

    private static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
    {
        builder.Services.AddTransient<ISemanticScreenReader, Services.SemanticScreenReader>();

        return builder;
    }

    private static MauiAppBuilder RegisterViewsAndViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddTransient<HomePage>();
        builder.Services.AddTransient<HomePageViewModel>();
        builder.Services.AddTransient<AccessibilityContentViewPage>();
        builder.Services.AddTransient<AccessibilityContentViewPageViewModel>();

        return builder;
    }
}