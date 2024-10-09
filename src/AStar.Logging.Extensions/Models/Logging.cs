namespace AStar.Logging.Extensions.Models;

/// <summary>
///
/// </summary>
public class Logging
{
    /// <summary>
    ///
    /// </summary>
    public Console Console { get; set; } = new();

    /// <summary>
    ///
    /// </summary>
    public ApplicationInsights ApplicationInsights { get; set; } = new();
}
