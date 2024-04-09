using FidelityBTG.MVVM.ViewModels;
using FidelityBTG.MVVM.Views;
using FidelityBTG.Services;
using Microsoft.Extensions.Logging;

namespace FidelityBTG
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<AddClientViewModel>();
            builder.Services.AddTransient<ClientsViewModel>();
            builder.Services.AddTransient<UpdateClientViewModel>();

            builder.Services.AddSingleton<ClientsPage>();
            builder.Services.AddTransient<AddClientPage>();
            builder.Services.AddTransient<UpdateClientPage>();

            builder.Services.AddSingleton<IClientService, ClientService>();

            return builder.Build();
        }
    }
}
