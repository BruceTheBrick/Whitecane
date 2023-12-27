using WhiteCane.Controls;

namespace WhiteCane.Handlers;

public partial class AccessibilityContentViewHandler
{
    public static readonly IPropertyMapper<AccessibilityContentView, AccessibilityContentViewHandler> PropertyMapper =
        new PropertyMapper<AccessibilityContentView, AccessibilityContentViewHandler>
        {
            [nameof(AccessibilityContentView.IncrementCommand)] = MapIncrementCommand,
            [nameof(AccessibilityContentView.DecrementCommand)] = MapDecrementCommand,
            [nameof(AccessibilityContentView.Actions)] = MapActions,
        };

    public AccessibilityContentViewHandler()
        : base(PropertyMapper)
    {
    }
}