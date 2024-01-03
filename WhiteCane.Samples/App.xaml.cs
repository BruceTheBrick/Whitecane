using System.Diagnostics.CodeAnalysis;

namespace WhiteCane.Samples;

public partial class App
{
    [ExcludeFromCodeCoverage]
    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
    }
}