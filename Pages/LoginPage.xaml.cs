using AppSnacks.Services;
using AppSnacks.Validators;

namespace AppSnacks.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    public LoginPage(ApiService apiService, IValidator validator)
    {
        ApiService = apiService;
        Validator = validator;
    }

    public ApiService ApiService { get; }
    public IValidator Validator { get; }
}