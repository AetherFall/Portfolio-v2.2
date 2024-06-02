using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Models.DAO.PRO;
using Domain.Models.DAO.SYS;
using Domain.Models.DAO.USR;

namespace Domain.Models.DAO.INT;

public class INT_ProjetAPI
{
    [Key]
    public int Id { get; set; }
    
    [ForeignKey("Project")]
    public int ProjectId { get; set; }
    
    [ForeignKey("API")]
    public int APIId { get; set; }

    public USR_Project Project { get; set; }
    public SYS_API API { get; set; }
}