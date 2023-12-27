#if IOS
using UIKit;

namespace WhiteCane.Controls;

public partial class AccessibilityContentView : UIView
{
    public override void AccessibilityIncrement()
    {
        base.AccessibilityIncrement();
        IncrementCommand?.Execute(null);
    }

    public override void AccessibilityDecrement()
    {
        base.AccessibilityDecrement();
        DecrementCommand?.Execute(null);
    }

    public override UIAccessibilityCustomAction[] AccessibilityCustomActions => GetActions();

    private UIAccessibilityCustomAction[] GetActions()
    {
        throw new NotImplementedException();
    }
}
#endif