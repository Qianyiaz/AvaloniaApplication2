using Avalonia.Controls;
using AvaloniaApplication2.ViewModels;

namespace AvaloniaApplication2.Views;

public partial class SettingsPage : UserControl
{
    public SettingsPage() => InitializeComponent();

    public SettingsPage(SettingsPageViewModel vm) : this() => DataContext = vm;
}