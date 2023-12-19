using ExámenParcial2.ViewModels;

namespace ExámenParcial2.Views;

public partial class LoginPage2 : ContentPage
{
    public LoginPage2(LoginPageViewModel loginPageViewModel)
    {
        InitializeComponent();
        BindingContext = loginPageViewModel;
    }
}