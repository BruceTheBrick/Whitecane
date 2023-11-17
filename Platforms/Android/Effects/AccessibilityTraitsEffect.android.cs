using System.ComponentModel;
using System.Diagnostics;
using WhiteCane.Core;
using WhiteCane.Effects;

namespace WhiteCane.Droid.Effects;

internal class AccessibilityTraitsEffect : TraitsEffect
{
    private Android.Views.View _view;
    protected override void OnAttached()
    {
        _view = Control ?? Container;
        SetTraits();
    }

    protected override void OnDetached()
    {
    }

    protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
    {
        base.OnElementPropertyChanged(args);
        SetTraits();
    }

    protected override void SetTraits()
    {
        var traits = GetTraitsFromElement();
        SetClickable(traits);
        SetHeading(traits);
        SetSelected(traits);
        SetActivated();
    }

    private void SetClickable(Traits traits)
    {
        _view.Clickable = traits.HasFlag(Traits.Button);
    }

    [Conditional("ANDROID28_0_OR_GREATER")]
    private void SetHeading(Traits traits)
    {
        _view.AccessibilityHeading = traits.HasFlag(Traits.Header);
    }

    private void SetSelected(Traits traits)
    {
        _view.Selected = traits.HasFlag(Traits.Selected);
    }
    
    private void SetActivated()
    {
        if (Element is IView elementView)
        {
            _view.Activated = elementView.IsEnabled;
        }
    }
}