using Avalonia.Controls;
using AvaloniaApplication2.ViewModels;

namespace AvaloniaApplication2.Views;

public partial class HomePage : UserControl
{
    public HomePage() => InitializeComponent();

    public HomePage(HomePageViewModel vm) : this() => DataContext = vm;
}