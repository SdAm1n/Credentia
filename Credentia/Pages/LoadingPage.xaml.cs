using Credentia.Services;

namespace Credentia.Pages;

public partial class LoadingPage : ContentPage
{
    private readonly AuthService _authService;

    public LoadingPage(AuthService authService)
    {
        InitializeComponent();

        this._authService = authService;
    }

    protected async override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        var isAuthenticated = await _authService.IsAuthenticatedAsync();

        if (isAuthenticated)
        {
            // User is Logged In
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
        else
        {
            // User is not Logged In
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}