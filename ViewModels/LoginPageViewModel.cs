using CommunityToolkit.Maui.Alerts;
using ExámenParcial2.Models;
using ExámenParcial2.Services.Interfaces;
using System.ComponentModel;

namespace ExámenParcial2.ViewModels;

public class LoginPageViewModel : INotifyPropertyChanged
{
    private readonly ILoginService loginService;

    public string Usuario { get; set; }
    public string Contraseña { get; set; }
    public Command LoginCommand { get; set; }
    public LoginPageViewModel(ILoginService loginService)
    {
        this.loginService = loginService;
        LoginCommand = new Command(LoginAsync);
        Settings.EmailList = "gustavo@gmail.com";
        Settings.PasswordList = "12345";
    }
    private async void LoginAsync()
    {
        var validar = await loginService.LoginAsync(Usuario, Contraseña);

        if (validar == false)
        {
            await ShowToastAsync("No fue posible iniciar sesion");
            return;
        }
        await ShowToastAsync("Inicio de Sesion Satisfactorio");
    }

    private async Task ShowToastAsync(string message)
    {
        // implement your logic here
        var toast = Toast.Make(message);
        var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));
        await toast.Show(cts.Token);
    }
    public event PropertyChangedEventHandler PropertyChanged;
}