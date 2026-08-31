using Avalonia.Controls;
using Avalonia.Styling;

namespace AvaloniaApplication2.Service;

public interface ITopLevelService
{
    public WindowTransparencyLevel ActualTransparencyLevel { get; }
    public ThemeVariant RequestedThemeVariant { get; }
    public void SetHostTopLevel(TopLevel topLevel);
    public void SetThemeVariant(ThemeVariant theme);
    public void SetTransparencyLevelHint(WindowTransparencyLevel level);
}

public class TopLevelService : ITopLevelService
{
    private TopLevel _topLevel = null!;

    public void SetHostTopLevel(TopLevel topLevel) => _topLevel = topLevel;

    public void SetThemeVariant(ThemeVariant theme) => _topLevel.RequestedThemeVariant = theme;

    public void SetTransparencyLevelHint(WindowTransparencyLevel level) => _topLevel.TransparencyLevelHint = [level];

    public WindowTransparencyLevel ActualTransparencyLevel => _topLevel.ActualTransparencyLevel;

    public ThemeVariant RequestedThemeVariant => _topLevel.RequestedThemeVariant!;
}