namespace AStar.Logging.Extensions.Models;

/// <summary>
///
/// </summary>
public class SerilogConfig
{
    /// <summary>
    ///
    /// </summary>
    public Serilog Serilog { get; set; } = new();

    /// <summary>
    ///
    /// </summary>
    public Logging Logging { get; set; } = new();
}
