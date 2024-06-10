using System.Reflection;
using Application.Mappers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Sinks.Grafana.Loki;

namespace Infrastructure.Settings;

public static class TelemetryConfig
{
    public static IServiceCollection AddTelemetry(this IServiceCollection services, IHostBuilder builder)
    {
        builder.UseSerilog((_hostingContext, loggerConfiguration) =>
        {
            loggerConfiguration.ReadFrom.Configuration(_hostingContext.Configuration);
            loggerConfiguration.Enrich.WithProperty("Application", _hostingContext.HostingEnvironment.ApplicationName);
            loggerConfiguration.Enrich.WithProperty("Environment", _hostingContext.HostingEnvironment.EnvironmentName);
            loggerConfiguration.Enrich.WithProperty("Version", Assembly.GetEntryAssembly()?.GetName().Version?.ToString());
        });
        
        return services;
    }
}