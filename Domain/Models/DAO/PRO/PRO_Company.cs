using System.ComponentModel.DataAnnotations;
using Domain.Models.DAO.USR;

namespace Domain.Models.DAO.PRO;

public class PRO_Company
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    
    /// <summary>
    /// Logo - Format HTML / SVG
    /// </summary>
    public string? Logo { get; set; }
    public string? LogoBackgroundColor { get; set; }
    public string? Description { get; set; }
    public string? Website { get; set; }

    private ICollection<USR_Project> Projects { get; set; }
    private ICollection<USR_Experience> Experiences { get; set; }
}