using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Models.DAO.PRO;
using Domain.Models.DAO.SYS;
using Domain.Models.DAO.USR;

namespace Domain.Models.DAO.INT;

public class INT_ProjectLangage
{
    [Key]
    public int Id { get; set; }
    
    [ForeignKey("Project")]
    public int ProjectId { get; set; }

    [ForeignKey("Langage")]
    public int LangageId { get; set; }

    public bool IsMainForProject { get; set; } = false;
    public bool IsFrontEnd { get; set; } = false;
    
    public USR_Project Project { get; set; }
    public SYS_Langage Langage { get; set; }
}