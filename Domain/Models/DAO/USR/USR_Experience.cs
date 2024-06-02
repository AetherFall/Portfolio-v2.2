using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Models.DAO.PRO;

namespace Domain.Models.DAO.USR;

public class USR_Experience
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public DateTime? DateDebut { get; set; }
    public DateTime? DateFin { get; set; }

    [ForeignKey("Company")]
    public int CompanyId { get; set; }

    public bool IsCurrent { get; set; } = false;
    public bool IsActive { get; set; } = true;
    
    public PRO_Company Company { get; set; }
}