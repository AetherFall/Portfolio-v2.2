using Application.Mappers;
using Infrastructure.Context;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Settings;

public static class MapperConfig
{
    public static IServiceCollection ConfigureMappers(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(INTProfile));
        services.AddAutoMapper(typeof(PROProfile));
        services.AddAutoMapper(typeof(SYSProfile));
        services.AddAutoMapper(typeof(USRProfile));
        
        return services;
    }
}