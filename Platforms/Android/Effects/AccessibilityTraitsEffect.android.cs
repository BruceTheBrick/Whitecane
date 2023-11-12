using WhiteCane.Effects;

namespace WhiteCane.Droid.Effects;

public class AccessibilityTraitsEffect : TraitsEffect
{
    private Android.Views.View _view;
    protected override void OnAttached()
    {
        _view = Control ?? Container;
    }

    protected override void OnDetached()
    {
    }

    protected override void SetTraits()
    {
    }
}