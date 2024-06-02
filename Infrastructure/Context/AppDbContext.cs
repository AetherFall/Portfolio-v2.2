using Domain.Models.DAO.INT;
using Domain.Models.DAO.PRO;
using Domain.Models.DAO.SYS;
using Domain.Models.DAO.USR;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class AppDbContext : DbContext
{
    public AppDbContext() { }

    public AppDbContext(DbContextOptions<AppDbContext> options): base(options){ }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(new MariaDbServerVersion(new Version(11, 3)));
    }

    public DbSet<INT_CompetenceCategory> INT_CompetenceCategory { get; set; } = null!;
    public DbSet<INT_ProjectImage> INT_ProjectImage { get; set; } = null!;
    public DbSet<INT_ProjectLangage> INT_ProjectLangage { get; set; } = null!;
    public DbSet<INT_ProjectLink> INT_ProjectLink { get; set; } = null!;
    public DbSet<INT_ProjetAPI> INT_ProjetAPI { get; set; } = null!;
    public DbSet<PRO_Company> PRO_Company { get; set; } = null!;
    public DbSet<SYS_API> SYS_API { get; set; } = null!;
    public DbSet<SYS_Langage> SYS_Langage { get; set; } = null!;
    public DbSet<SYS_NavBar> SYS_NavBar { get; set; } = null!;
    public DbSet<SYS_Settings> SYS_Settings { get; set; } = null!;
    public DbSet<SYS_Statut> SYS_Statut { get; set; } = null!;
    public DbSet<USR_Competence> USR_Competence { get; set; } = null!;
    public DbSet<USR_Contact> USR_Contact { get; set; } = null!;
    public DbSet<USR_Experience> USR_Experience { get; set; } = null!;
    public DbSet<USR_Project> USR_Project { get; set; } = null!;
}