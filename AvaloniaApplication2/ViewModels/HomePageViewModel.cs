using AvaloniaApplication2.Service;
using AvaloniaApplication2.Views;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaApplication2.ViewModels;

public partial class HomePageViewModel(INavigationService nav)
{
    [RelayCommand]
    private void NavigateToSettings() => nav.Navigate<SettingsPage>();
}