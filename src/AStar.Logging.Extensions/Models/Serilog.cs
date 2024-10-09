namespace AStar.Logging.Extensions.Models;

/// <summary>
///
/// </summary>
public class Serilog
{
    /// <summary>
    ///
    /// </summary>
    public string[] Enrich { get; set; } = Array.Empty<string>();

    /// <summary>
    ///
    /// </summary>
    public WriteTo[] WriteTo { get; set; } = Array.Empty<WriteTo>();

    /// <summary>
    ///
    /// </summary>
    public Minimumlevel MinimumLevel { get; set; } = new();
}
