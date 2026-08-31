using AvaloniaApplication2.Models;
using AvaloniaApplication2.ViewModels;
using AvaloniaApplication2.Views;
using Jab;

namespace AvaloniaApplication2.Service;

[ServiceProvider]
[Singleton<MainWindow>]
[Transient<HomePage>]
[Transient<SettingsPage>]
[Transient<HomePageViewModel>]
[Transient<SettingsPageViewModel>]
[Singleton<MyPageFactory>]
[Singleton<INavigationService, NavigationService>]
[Singleton<ITopLevelService, TopLevelService>]
public partial class MyServiceProvider;