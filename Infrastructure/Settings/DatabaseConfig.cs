using Infrastructure.Context;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Settings;

public static class DatabaseConfig
{
    public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseMySql(configuration.GetConnectionString("DefaultConnection")!, new MariaDbServerVersion(new Version(11,3)));
        });
        
        using var serviceScope = services.BuildServiceProvider().CreateScope();
        var context = serviceScope.ServiceProvider.GetRequiredService<AppDbContext>();
        
        var pendingMigrations = context.Database.GetPendingMigrations();
        
        if (pendingMigrations.Any())
            context.Database.Migrate();
        
        DatabaseSeeder.Seed(serviceScope.ServiceProvider);
        
        return services;
    }
}