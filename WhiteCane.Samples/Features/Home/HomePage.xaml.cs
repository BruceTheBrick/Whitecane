using System.Diagnostics.CodeAnalysis;

namespace WhiteCane.Samples.Features;

[ExcludeFromCodeCoverage]
public partial class HomePage
{
    public HomePage(HomePageViewModel viewModel)
        : base(viewModel)
    {
        InitializeComponent();
    }
}