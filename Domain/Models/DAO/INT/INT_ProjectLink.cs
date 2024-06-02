using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Models.DAO.PRO;
using Domain.Models.DAO.USR;

namespace Domain.Models.DAO.INT;

public class INT_ProjectLink
{
    [Key]
    public int Id { get; set; }
    
    [ForeignKey("Project")]
    public int ProjectId { get; set; }
    
    [MaxLength(255)]
    public string Name { get; set; }
    
    [MaxLength(512)]
    public string Url { get; set; }
    public string? SVGIcon { get; set; }
    
    [MaxLength(255)]
    public string? Description { get; set; }
    
    public USR_Project Project { get; set; }
}