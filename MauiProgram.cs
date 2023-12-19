﻿using ExámenParcial2.Services;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace ExámenParcial2;
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

#if DEBUG
        builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<Views.LoginPage2>();
        builder.Services.AddSingleton<ViewModels.LoginPageViewModel>();
        builder.Services.AddSingleton<Services.Interfaces.ILoginService, LoginService>();

        return builder.Build();
    }
}