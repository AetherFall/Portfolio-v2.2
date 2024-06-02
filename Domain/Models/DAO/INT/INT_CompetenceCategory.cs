using System.ComponentModel.DataAnnotations;
using Domain.Models.DAO.PRO;
using Domain.Models.DAO.USR;

namespace Domain.Models.DAO.INT;

public class INT_CompetenceCategory
{
    [Key]
    public int Id { get; set; }
    
    [MaxLength(255)]
    public string Name { get; set; }
    
    [MaxLength(7)]
    public string? BackgroundColor { get; set; }
    
    [MaxLength(7)]
    public string? ForegroundColor { get; set; }

    public bool IsSoftwareSkill { get; set; } = true;

    public ICollection<USR_Competence> Competences { get; set; }
}