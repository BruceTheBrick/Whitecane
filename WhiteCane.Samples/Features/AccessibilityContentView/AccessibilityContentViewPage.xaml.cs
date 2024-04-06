using System.Diagnostics.CodeAnalysis;

namespace WhiteCane.Samples.Features;

[ExcludeFromCodeCoverage]
public partial class AccessibilityContentViewPage
{
    public AccessibilityContentViewPage(AccessibilityContentViewPageViewModel viewModel)
        : base(viewModel)
    {
        InitializeComponent();
    }
}