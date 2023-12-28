using WhiteCane.Effects;
using WhiteCane.iOS.Effects;

namespace WhiteCane.Platforms;

internal static class PlatformInitializer
{
    internal static void InitializePlatform(this MauiAppBuilder builder)
    {
        builder.ConfigureEffects(RegisterPlatformEffects);
    }
    
    private static void RegisterPlatformEffects(IEffectsBuilder effects)
    {
        effects.Add(typeof(AccessibilityTraits), typeof(AccessibilityTraitsEffect));
    }
}