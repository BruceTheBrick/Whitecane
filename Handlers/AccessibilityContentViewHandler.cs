using WhiteCane.Controls;

namespace WhiteCane.Handlers;

public partial class AccessibilityContentViewHandler
{
    public readonly static PropertyMapper<IAccessibilityContentView, AccessibilityContentViewHandler> PropertyMapper = 
        new(ViewMapper)
    {
        [nameof(IAccessibilityContentView.IncrementCommand)] = MapIncrementCommand,
        [nameof(IAccessibilityContentView.DecrementCommand)] = MapDecrementCommand,
        [nameof(IAccessibilityContentView.Actions)] = MapActions,
    };

    public AccessibilityContentViewHandler() 
        : base(PropertyMapper)
    {
    }
}