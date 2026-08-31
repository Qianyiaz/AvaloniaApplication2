using Avalonia.Controls;
using FluentAvalonia.UI.Controls;

namespace AvaloniaApplication2.Models;

public class MyPageFactory(IServiceProvider sp) : IFANavigationPageFactory
{
    public Control GetPage(Type srcType) =>
        sp.GetService(srcType) as Control
        ?? throw new InvalidOperationException($"Type '{srcType}' is not registered.");

    public Control GetPageFromObject(object target) => throw new NotImplementedException();
}