
using Credentia.Services;

namespace Credentia.Pages;

public partial class LoginPage : ContentPage
{
    private readonly AuthService _authService;

    public LoginPage(AuthService authService)
	{
        InitializeComponent();
        this._authService = authService;
    }

    private async void LoginButtonClickedAsync(object sender, EventArgs e)
    {
        // Set Login State
        _authService.Login();

        await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }
}