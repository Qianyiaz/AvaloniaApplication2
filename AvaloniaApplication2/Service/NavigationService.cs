using FluentAvalonia.UI.Controls;

namespace AvaloniaApplication2.Service;

public interface INavigationService
{
    bool CanGoBack { get; }
    public void SetHostFrame(FAFrame frame);
    public void Navigate<TControl>(bool isSyncMenu = true);
    void GoBack();
}

public class NavigationService : INavigationService
{
    private FAFrame _frame = null!;

    public void SetHostFrame(FAFrame frame) => _frame = frame;

    public void Navigate<TControl>(bool isSyncMenu = true) => _frame.Navigate(typeof(TControl), isSyncMenu);

    public void GoBack() => _frame.GoBack();

    public bool CanGoBack => _frame.CanGoBack;
}