using WhiteCane.Effects;
using WhiteCane.Handlers;
using WhiteCane.Platforms.iOS.Effects;

namespace WhiteCane.Platforms;

internal static class PlatformInitializer
{
    internal static void InitializePlatform(this MauiAppBuilder builder)
    {
        builder.ConfigureEffects(RegisterPlatformEffects);
        builder.ConfigureMauiHandlers(RegisterPlatformHandlers);
    }

    private static void RegisterPlatformEffects(IEffectsBuilder effects)
    {
        effects.Add<AccessibilityTraits, AccessibilityTraitsEffect>();
    }
    
    private static void RegisterPlatformHandlers(IMauiHandlersCollection handlers)
    {
        handlers.AddHandler(typeof(AccessibilityContentView), typeof(AccessibilityContentViewHandler));
    }
}