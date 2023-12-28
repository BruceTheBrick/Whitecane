using System.Diagnostics.CodeAnalysis;

namespace WhiteCane.Effects;

[ExcludeFromCodeCoverage]
public class AccessibilityTraits : RoutingEffect
{
    public static readonly BindableProperty TraitsProperty = BindableProperty.Create(
        "Traits",
        typeof(Traits),
        typeof(AccessibilityTraits));

    public static void SetTraits(BindableObject view, Traits traits)
    {
        view.SetValue(TraitsProperty, traits);
    }
    
    public static Traits GetTraits(BindableObject view)
    {
        return (Traits)view.GetValue(TraitsProperty);
    }
}