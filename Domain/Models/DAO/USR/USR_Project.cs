using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Models.DAO.INT;
using Domain.Models.DAO.PRO;

namespace Domain.Models.DAO.USR;

public class USR_Project
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DateDebut { get; set; }
    public DateTime DateFin { get; set; }
    public string Statut { get; set; }
    public string Logo { get; set; }
    public bool IsActive { get; set; }
    
    [ForeignKey("Company")]
    public int CompanyId { get; set; }
    
    public string NoteClient { get; set; }

    public PRO_Company Company { get; set; }
    public ICollection<INT_ProjetAPI> ProjectAPIs { get; set; }
    public ICollection<INT_ProjectLangage> ProjectLangages { get; set; }
    public ICollection<INT_ProjectImage> ProjectImages { get; set; }
    public ICollection<INT_ProjectLink> LinkProjects { get; set; }
}