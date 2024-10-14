using AppSnacks.Pages;

namespace AppSnacks
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new RegisterPage());
        }
    }
}
