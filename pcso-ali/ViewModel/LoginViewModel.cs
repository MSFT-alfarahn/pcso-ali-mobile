
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace pcso_ali.ViewModel;

public partial class LoginViewModel : BaseViewModel
{
    [ObservableProperty]
    private string username;

    [ICommand]
    public void GoToHome()
    {
        Shell.Current.GoToAsync("//Tabs");
    }
}
