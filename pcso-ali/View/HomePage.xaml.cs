using pcso_ali.ViewModel;

namespace pcso_ali.View;

public partial class HomePage : ContentPage
{
	public HomePage(HomeViewModel homeViewModel) 
	{
		InitializeComponent();
		BindingContext = homeViewModel;
	}
}