﻿using Microsoft.Maui.Controls.Platform;
using WhiteCane.Core;

namespace WhiteCane.Effects;

public abstract class TraitsEffect : PlatformEffect
{
    protected abstract void SetTraits();

    protected Traits GetTraitsFromElement()
    {
        return AccessibilityTraits.GetTraits(Element);
    }
}