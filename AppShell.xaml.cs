using AppSnacks.Pages;
using AppSnacks.Services;
using AppSnacks.Validators;

namespace AppSnacks
{
    public partial class AppShell : Shell
    {
        private readonly ApiService _apiService;
        private readonly IValidator _validator;
        private readonly FavoriteService _favoriteService;
        private ApiService apiService;
        private IValidator validator;

        public AppShell(ApiService apiService, IValidator validator)
        {
            this.apiService = apiService;
            this.validator = validator;
        }

        public AppShell(ApiService apiService, IValidator validator, FavoriteService favoriteService)
        {
            InitializeComponent();
            _apiService = apiService ?? throw new ArgumentNullException(nameof(apiService));
            _validator = validator;
            _favoriteService = favoriteService;
            ConfigureShell();
        }

        private void ConfigureShell()
        {
            var homePage = new HomePage(_apiService, _validator, _favoriteService);
            var cartPage = new CartPage(_apiService, _validator, _favoriteService);
            var favoritesPage = new FavoritesPage(_apiService, _validator, _favoriteService);
            var profilePage = new ProfilePage(_apiService, _validator, _favoriteService);

            Items.Add(new TabBar
            {
                Items =
            {
                new ShellContent { Title = "Home",Icon = "home",Content = homePage },
                new ShellContent { Title = "Cart", Icon = "cart",Content = cartPage },
                new ShellContent { Title = "Favorites",Icon = "heart",Content = favoritesPage },
                new ShellContent { Title = "Profile",Icon = "profile",Content = profilePage }
            }
            });
        }
    }
}
