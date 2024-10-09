namespace AStar.Logging.Extensions.Models;

/// <summary>
///
/// </summary>
public class Formatteroptions
{
    /// <summary>
    ///
    /// </summary>
    public bool SingleLine { get; set; }

    /// <summary>
    ///
    /// </summary>
    public bool IncludeScopes { get; set; }

    /// <summary>
    ///
    /// </summary>
    public string TimestampFormat { get; set; } = string.Empty;

    /// <summary>
    ///
    /// </summary>
    public bool UseUtcTimestamp { get; set; }

    /// <summary>
    ///
    /// </summary>
    public JsonWriterOptions JsonWriterOptions { get; set; } = new();
}
