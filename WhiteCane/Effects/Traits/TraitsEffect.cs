using Microsoft.Maui.Controls.Platform;

namespace WhiteCane.Effects;

internal abstract class TraitsEffect : PlatformEffect
{
    protected abstract void SetTraits();

    protected Traits GetTraitsFromElement()
    {
        return AccessibilityTraits.GetTraits(Element);
    }
}