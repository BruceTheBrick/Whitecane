using System.Diagnostics.CodeAnalysis;

namespace WhiteCane.Effects;

[ExcludeFromCodeCoverage]
public class AccessibilityTraits : RoutingEffect
{
    public static readonly BindableProperty TraitsProperty = BindableProperty.Create(
        "Traits",
        typeof(Core.Traits),
        typeof(AccessibilityTraits));

    public static void SetTraits(BindableObject view, Core.Traits traits)
    {
        view.SetValue(TraitsProperty, traits);
    }
    
    public static Core.Traits GetTraits(BindableObject view)
    {
        return (Core.Traits)view.GetValue(TraitsProperty);
    }
}