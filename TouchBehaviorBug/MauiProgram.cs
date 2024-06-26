﻿using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace TouchBehaviorBug;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
        
        builder.Services.AddTransient<MainPageViewModel>();
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<MainPage2>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}