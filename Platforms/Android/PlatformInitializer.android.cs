#if ANDROID
using WhiteCane.Droid.Effects;
using WhiteCane.Effects;

namespace WhiteCane.Platforms;

internal static class PlatformInitializer
{
    internal static MauiAppBuilder InitializePlatform(this MauiAppBuilder builder)
    {
        builder.ConfigureEffects(RegisterPlatformEffects);
        return builder;
    }

    private static void RegisterPlatformEffects(IEffectsBuilder effects)
    {
        effects.Add(typeof(AccessibilityTraits), typeof(AccessibilityTraitsEffect));
    }
}
#endif