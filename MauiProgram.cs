using Microsoft.Maui.Controls;
using Microsoft.Maui.Hosting;
using AppHotel.Views;

namespace AppHotel;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        // Adicionando serviços e configurações
        builder
            .UseMauiApp<App>()  // Define a classe principal do aplicativo
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        // Registrando as páginas, caso necessário (exemplo)
        builder.Services.AddSingleton<MainPage>();

        return builder.Build();
    }
}
