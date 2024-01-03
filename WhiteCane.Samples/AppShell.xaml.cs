using System.Diagnostics.CodeAnalysis;

namespace WhiteCane.Samples;

public partial class AppShell
{
    [ExcludeFromCodeCoverage]
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