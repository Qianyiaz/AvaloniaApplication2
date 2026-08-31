using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaApplication2.Service;
using AvaloniaApplication2.Views;

namespace AvaloniaApplication2;

public class App : Application
{
    public override void Initialize() => AvaloniaXamlLoader.Load(this);

    public override void OnFrameworkInitializationCompleted()
    {
        using var sp = new MyServiceProvider();
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            desktop.MainWindow = sp.GetService<MainWindow>();

        base.OnFrameworkInitializationCompleted();
    }
}