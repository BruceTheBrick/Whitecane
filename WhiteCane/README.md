<img src="/Assets/Whitecane_logo.png?raw=true" alt="WhiteCane Logo" width="150px" height="150px"/>

# WhiteCane
WhiteCane is an open-source .NET package that aims to assist developers in creating accessible applications
that can be used by everyone.

# Documentation

## Getting Started
WhiteCane follows the standard `MauiApplicationBuilder` extensions. To get started, be sure to call the extension
method from `MauiProgram.cs` like so:

```csharp
using WhiteCane;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.UseMauiApp<App>()
			
			// Initialize WhiteCane by calling its extension
			.UseWhiteCane();

		// Continue initializing your .NET MAUI App here
		return builder.Build();
	}
}
```

## Features

### Accessibility Traits
For users that utilize screen reading technologies such as 
IOS' [VoiceOver](https://support.apple.com/en-gb/guide/iphone/iph3e2e415f/ios#:~:text=With%20VoiceOver%E2%80%94a%20gesture%2Dbased,pitch%20to%20suit%20your%20needs) 
and Android's [TalkBack](https://support.google.com/accessibility/android/answer/6283677?hl=en), it can be difficult 
to determine which actions a given UI element allows. Accessibility Traits provide additional context and functionality 
to make interacting with applications easier.