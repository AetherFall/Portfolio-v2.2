using Domain.Models.DAO.SYS;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Data;

public static class DatabaseSeeder
{
    public static void Seed(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());
        
        InitializeStatuts(context);
        InitializeLangages(context);
        InitializeAPIs(context);
        InitializeNavBar(context);
        InitializeSettings(context);
    }
    
    private static void InitializeStatuts(AppDbContext context)
    {        
        if (context.SYS_Statut.Any())
            return;
        
        var lstStatut = new List<SYS_Statut>
        {
            new SYS_Statut
            {
                Name = "En cours", 
                IsStarted = true, 
                IsFinished = false
            },
            new SYS_Statut
            {
                Name = "Terminé", 
                IsStarted = true, 
                IsFinished = true
            },
            new SYS_Statut
            {
                Name = "Prochainement", 
                IsStarted = false, 
                IsFinished = false
            }
        };
        
        context.SYS_Statut.AddRange(lstStatut);
        context.SaveChanges();
    }
    
    public static void InitializeLangages(AppDbContext context)
    {
        if (context.SYS_Langage.Any())
            return;
        
        var lstLangages = new List<SYS_Langage>
        {
            new()
            {
                Name = "C++"
            },
            new()
            {
                Name = "C#"
            },
            new()
            {
                Name = "Python"
            },
            new()
            {
                Name = "Go"
            },
            new()
            {
                // Ceci n'est pas un langage de programmation, je suis déjà au courant
                // Mais je ne ferais pas une table juste pour les langages de balisage
                Name = "HTML / CSS"
            },
            new()
            {
                Name = "PHP"
            },
            new()
            {
                Name = "TypeScript"
            },
            new()
            {
                Name = "Kotlin"
            },
            new()
            {
                Name = "Swift"
            },
            new()
            {
                Name = ".NET", 
                IsFramework = true
            },
            new()
            {
                Name = "Blazor", 
                IsFramework = true
            },
            new()
            {
                Name = "ASP.NET", 
                IsFramework = true
            },
            new()
            {
                Name = "MAUI", 
                IsFramework = true
            },
            new()
            {
                Name = "MAUI x Blazor", 
                IsFramework = true
            },
            new()
            {
                Name = "Flask", 
                IsFramework = true
            },
            new()
            {
                Name = "Node.js", 
                IsFramework = true
            },
            new()
            {
                Name = "Express", 
                IsFramework = true
            },
            new()
            {
                Name = "MariaDB", 
                IsSGBD = true
            },
            new()
            {
                Name = "SQL Server", 
                IsSGBD = true
            },
            new()
            {
                Name = "MongoDB", 
                IsSGBD = false
            },
            new()
            {
                Name = "SQLite", 
                IsSGBD = true
            },
            new()
            {
                Name = "Bootstrap", 
                IsFramework = true
            },
            new()
            {
                Name = "TailwindCSS", 
                IsFramework = true
            }
        };
        
        context.SYS_Langage.AddRange(lstLangages);
        context.SaveChanges();
    }
    
    public static void InitializeAPIs(AppDbContext context)
    {
        if (context.SYS_API.Any())
            return;
        
        var lstAPIs = new List<SYS_API>
        {
            new()
            {
                Name = "Strippe",
                Description = "API de paiement",
                Website = "https://stripe.com/"
            },
            new()
            {
                Name = "SendGrid",
                Description = "API d'envoi de mail",
                Website = "https://sendgrid.com/"
            },
            new()
            {
                Name = "OpenWeather",
                Description = "API météorologique",
                Website = "https://openweathermap.org/api"
            },
            new()
            {
                Name = "Virustotal",
                Description = "API de scan de fichier",
                Website = "https://www.virustotal.com/gui/"
            },
            new()
            {
                Name = "Deck of Cards",
                Description = "API de jeu de carte",
                Website = "https://deckofcardsapi.com/"
            }
        };
        
        context.SYS_API.AddRange(lstAPIs);
        context.SaveChanges();
    }
    
    public static void InitializeNavBar(AppDbContext context)
    {
        if (context.SYS_NavBar.Any())
            return;
        
        var lstNavBar = new List<SYS_NavBar>
        {
            new()
            {
                Name = "Accueil",
                Url = "/",
                IsHome = true
            },
            new()
            {
                Name = "Expériences",
                Url = "/experiences"
            },
            new()
            {
                Name = "Compétences",
                Url = "/competences"
            },
            new()
            {
                Name = "Projets",
                Url = "/projets"
            },
            new()
            {
                Name = "Contact",
                Url = ":contact:"
            }
        };
        
        context.SYS_NavBar.AddRange(lstNavBar);
        context.SaveChanges();
    }
    
    public static void InitializeSettings(AppDbContext context)
    {
        if (context.SYS_Settings.Any())
            return;
        
        var lstSettings = new List<SYS_Settings>
        {
            new()
            {
                Name = "CVLink",
                Value = "/assets/cv.pdf"
            }
        };
    }
}