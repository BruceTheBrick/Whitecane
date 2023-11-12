using WhiteCane.Platforms;

namespace WhiteCane;

public static class WhiteCane
{
    public static MauiAppBuilder UseWhiteCane(this MauiAppBuilder builder)
    {
        builder.InitializePlatform();
        return builder;
    }
}