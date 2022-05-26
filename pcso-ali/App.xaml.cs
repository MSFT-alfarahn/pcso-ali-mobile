using pcso_ali.View;

namespace pcso_ali;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new AppShell();
        Shell.Current.GoToAsync("//Login");
    }
}
