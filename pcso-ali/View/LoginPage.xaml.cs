using pcso_ali.ViewModel;

namespace pcso_ali.View;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		// instead of doing new LoginViewModel
		// I can resolve it in constructor because I did register
		
	}
}