using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Styling;
using AvaloniaApplication2.Service;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaApplication2.ViewModels;

public partial class SettingsPageViewModel(ITopLevelService topLevel) : ObservableObject
{
    [ObservableProperty] private ThemeVariant _selectedTheme = topLevel.RequestedThemeVariant;

    [ObservableProperty] private WindowTransparencyLevel _transparencyLevel = topLevel.ActualTransparencyLevel;

    public static AvaloniaList<WindowTransparencyLevel> TransparencyLevels { get; } =
    [
        WindowTransparencyLevel.Mica,
        WindowTransparencyLevel.AcrylicBlur,
        WindowTransparencyLevel.None
    ];

    public AvaloniaList<KeyValuePair<string, ThemeVariant>> ThemeOptions { get; } =
    [
        new("System", ThemeVariant.Default),
        new("Light", ThemeVariant.Light),
        new("Dark", ThemeVariant.Dark)
    ];

    partial void OnSelectedThemeChanged(ThemeVariant value) =>
        topLevel.SetThemeVariant(value);

    partial void OnTransparencyLevelChanged(WindowTransparencyLevel value) =>
        topLevel.SetTransparencyLevelHint(value);
}