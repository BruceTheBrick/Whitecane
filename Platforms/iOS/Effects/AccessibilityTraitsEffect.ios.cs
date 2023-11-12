using UIKit;
using WhiteCane.Effects;

namespace WhiteCane.iOS.Effects;

public class AccessibilityTraitsEffect : TraitsEffect
{
    private UIView _view;
    protected override void OnAttached()
    {
        _view = Control ?? Container;
        if (_view is null)
        {
            return;
        }

        SetTraits();
    }

    protected override void OnDetached()
    {
    }

    protected override void SetTraits()
    {
        var traits = GetTraitsFromElement();
        _view.AccessibilityTraits = (UIAccessibilityTrait)traits;
    }
}