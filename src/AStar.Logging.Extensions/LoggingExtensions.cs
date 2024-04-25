using System.Security.Cryptography;
using Serilog;

namespace AStar.Logging.Extensions;

/// <summary>
/// The <see cref="LoggingExtensions"/> class contains, as you might expect, extension methods for configuring Serilog / Application Insights.
/// </summary>
public static class LoggingExtensions
{    
    /// <summary>
    /// The <see cref="UseSerilogLogging"/> method will add Serilog to the logging providers.
    /// </summary>
    /// <param name="builder"></param>
    /// <returns>The original instance of <see cref="WebApplicationBuilder"/> for further method chaining.</returns>
    public static WebApplicationBuilder UseSerilogLogging(this WebApplicationBuilder builder)
    {                
        var services = builder.Services;
        _ = builder.Configuration.AddJsonFile(path: "astar-logging-settings.json", optional: false, reloadOnChange: true);

        _ = builder.Host.UseSerilog((context, loggerConfig) => loggerConfig
            .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level}] {Message:lj}{NewLine}{Exception}")
            .ReadFrom.Configuration(context.Configuration)
            .Enrich.FromLogContext());

        return builder;
    }
}