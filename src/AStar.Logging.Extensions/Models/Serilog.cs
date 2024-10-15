﻿namespace AStar.Logging.Extensions.Models;

/// <summary>
/// The <see cref="Serilog"/> class used to configure Serilog.
/// </summary>
public class Serilog
{
    /// <summary>
    /// An array of Enrichers to use.
    /// </summary>
    public string[] Enrich { get; set; } = Array.Empty<string>();

    /// <summary>
    /// An array of <see cref="WriteTo"/> configurations.
    /// </summary>
    public WriteTo[] WriteTo { get; set; } = Array.Empty<WriteTo>();

    /// <summary>
    /// The <see cref="MinimumLevel"/> log level to use.
    /// </summary>
    public MinimumLevel MinimumLevel { get; set; } = new();
}
