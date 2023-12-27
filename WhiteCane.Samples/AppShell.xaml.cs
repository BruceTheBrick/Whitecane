using WhiteCane.Samples.Features;

namespace WhiteCane.Samples;

public partial class AppShell
{
    public AppShell()
    {
        InitializeComponent();
        RegisterRoutes();
    }

    private void RegisterRoutes()
    {
        Routing.RegisterRoute(Routes.HomePage, typeof(HomePage));
        Routing.RegisterRoute(Routes.AccessibilityContentViewPage, typeof(AccessibilityContentViewPage));
    }
}