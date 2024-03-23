using Credentia.Pages;

namespace Credentia
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(CardPage), typeof(CardPage));
            Routing.RegisterRoute(nameof(IdentityPage), typeof(IdentityPage));
            Routing.RegisterRoute(nameof(PasswordGeneratorPage), typeof(PasswordGeneratorPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            Routing.RegisterRoute(nameof(SecureNotePage), typeof(SecureNotePage));
            Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));

        }


    }
}
