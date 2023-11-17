using UIKit;
using WhiteCane.Core;
using WhiteCane.Effects;

namespace WhiteCane.iOS.Effects;

internal class AccessibilityTraitsEffect : TraitsEffect
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
        traits = SetNotEnabled(traits);
        _view.AccessibilityTraits = (UIAccessibilityTrait)traits;
    }

    private Traits SetNotEnabled(Traits traits)
    {
        if (Element is not IView elementView)
        {
            return traits;
        }
        
        if (elementView.IsEnabled)
        {
            traits &=~ Traits.NotEnabled;
        }
        else
        {
            traits |= Traits.NotEnabled;
        }

        return traits;
    }
}