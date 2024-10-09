﻿namespace AStar.Logging.Extensions.Models;

/// <summary>
/// The <see cref="Args"/> class used by Serilog WriteTo section of the logging configuration.
/// </summary>
public class Args
{
    /// <summary>
    /// The Serilog server Url.
    /// </summary>
    public string ServerUrl { get; set; } = string.Empty;
}
