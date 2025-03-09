using Godot;
using Godot.Collections;

namespace Settings.Graphical;

public partial class Resolution: Node
{
    public Vector2I SelectedResolution { get; set; } = new Vector2I(1920, 1080);
    
    public static readonly Dictionary<string, Vector2I> Resolutions = new Dictionary<string, Vector2I>
    {
        { "2560x1440", new Vector2I(2560, 1440) },
        { "1920x1080", new Vector2I(1920, 1080) },
        { "1366x768", new Vector2I(1366, 768) },
        { "1280x720", new Vector2I(1280, 720) },
        { "1920x1200", new Vector2I(1920, 1200) },
        { "1680x1050", new Vector2I(1680, 1050) },
        { "1440x900", new Vector2I(1440, 900) },
        { "1280x800", new Vector2I(1280, 800) },
        { "1024x768", new Vector2I(1024, 768) },
        { "800x600", new Vector2I(800, 600) },
        { "640x480", new Vector2I(640, 480) },
    };

    public Array<string> DisplayOptions => (Array<string>)Resolutions.Keys;

    private bool IsValidResolution(string resolutionString)
    {
        return Resolutions.ContainsKey(resolutionString);
    }

    public bool ChangeResolution(string resolution)
    {
        if (IsValidResolution(resolution))
        {
            SelectedResolution = new Vector2I(SelectedResolution.X, SelectedResolution.Y);
        }

        return false;
    }

    private void SetSelectedResolution(Vector2I resolution)
    {
        
    }
}