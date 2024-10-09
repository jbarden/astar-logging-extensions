﻿namespace AStar.Logging.Extensions.Models;

/// <summary>
/// The <see cref="JsonWriterOptions"/> class containing the configuration options.
/// </summary>
public class JsonWriterOptions
{
    /// <summary>
    /// Whether to use indented JSON or not. The default is <see langword="false"/>.
    /// </summary>
    public bool Indented { get; set; }
}
