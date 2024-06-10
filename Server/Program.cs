using System.Reflection;
using Infrastructure.Context;
using Infrastructure.Data;
using Infrastructure.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen( options =>
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v2024",
        Title = "Portfolio - API",
        Description = "API pour le portfolio 2024",
        Contact = new OpenApiContact
        {
            Name = "- joingnez-moi par courriel",
            Email = "william-b.lambert@pm.me"
        },
        License = new OpenApiLicense
        {
            Name = "Creative Commons Attribution 4.0 International (CC BY 4.0)",
            Url = new Uri("https://github.com/AetherFall/Portfolio-v2.2/blob/main/LICENSE.md")
        }
    })
);

builder.Services.Scan(scan => scan
    .FromApplicationDependencies(app => app.FullName.StartsWith("Application") || app.FullName.StartsWith("Infrastructure") || app.FullName.StartsWith("Domain"))
    .AddClasses(classes => classes.Where(type => type.Name.EndsWith("Service")))
    .AsImplementedInterfaces()
    .WithTransientLifetime()
    .AddClasses(classes => classes.Where(type => type.Name.EndsWith("Repository")))
    .AsImplementedInterfaces()
    .WithTransientLifetime());


// Configurer la base de données
builder.Services.AddDatabase(builder.Configuration);
builder.Services.AddTelemetry(builder.Host);
builder.Services.ConfigureMappers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Portfolio API v2024");
        options.InjectStylesheet("/swagger-ui/custom.css");
        options.RoutePrefix = string.Empty;
    });
}

app.UseSerilogRequestLogging();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.Run();