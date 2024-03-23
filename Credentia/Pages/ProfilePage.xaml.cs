using Credentia.Services;

namespace Credentia.Pages;

public partial class ProfilePage : ContentPage
{
    private readonly AuthService _authService;

    public ProfilePage(AuthService authService)
	{
		InitializeComponent();
        this._authService = authService;
    }

    private async void LogoutButtonClickedAsync(object sender, EventArgs e)
    {
        // Set Logout State
        _authService.Logout();

        // Route to Login Page
        await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }
}