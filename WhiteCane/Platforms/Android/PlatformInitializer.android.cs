using Microsoft.Maui.Controls.Compatibility.Hosting;
using WhiteCane.Effects;
using WhiteCane.Handlers;
using WhiteCane.Droid.Effects;

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
        effects.AddCompatibilityEffects(typeof(AccessibilityTraits).Assembly, typeof(AccessibilityTraitsEffect).Assembly);
    }
    
    private static void RegisterPlatformHandlers(IMauiHandlersCollection handlers)
    {
        handlers.AddHandler(typeof(AccessibilityContentView), typeof(AccessibilityContentViewHandler));
    }
}