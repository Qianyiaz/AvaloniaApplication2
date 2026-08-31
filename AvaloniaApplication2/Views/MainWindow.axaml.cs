using AvaloniaApplication2.Models;
using AvaloniaApplication2.Service;
using FluentAvalonia.UI.Controls;
using FluentAvalonia.UI.Navigation;
using FluentAvalonia.UI.Windowing;

namespace AvaloniaApplication2.Views;

public partial class MainWindow : FAAppWindow
{
    public MainWindow() => InitializeComponent();

    public MainWindow(MyPageFactory pageFactory, INavigationService navigation, ITopLevelService topLevel) : this()
    {
        FrameView.NavigationPageFactory = pageFactory;
        navigation.SetHostFrame(FrameView);
        topLevel.SetHostTopLevel(this);
    }

    protected override void OnOpened(EventArgs e)
    {
        base.OnOpened(e);
        NavView.SelectedItem = NavView.MenuItems[0];
    }

    private void NavView_OnSelectionChanged(object? sender, FANavigationViewSelectionChangedEventArgs e)
    {
        if (e.SelectedItem is FANavigationViewItem { Tag: Type pageType } && pageType != FrameView.SourcePageType)
            FrameView.Navigate(pageType);
    }

    private void NavView_OnBackRequested(object? sender, FANavigationViewBackRequestedEventArgs e) =>
        FrameView.GoBack();

    private void FrameView_OnNavigated(object sender, FANavigationEventArgs e)
    {
        if (e.NavigationMode is FANavigationMode.Back && e.Parameter is false) return;
        var item = NavView.MenuItems
            .Concat(NavView.FooterMenuItems)
            .OfType<FANavigationViewItem>()
            .FirstOrDefault(i => i.Tag as Type == e.SourcePageType);

        if (item is not null && item != NavView.SelectedItem)
            NavView.SelectedItem = item;
    }
}