using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Models.DAO.INT;

namespace Domain.Models.DAO.USR;

public class USR_Competence
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    
    /// <summary>
    /// Icon name - Format HTML / SVG
    /// </summary>
    public string Icon { get; set; }

    [ForeignKey("CompetenceCategory")]
    public int CompetenceCategoryId { get; set; }
    
    public INT_CompetenceCategory CompetenceCategory { get; set; }
}