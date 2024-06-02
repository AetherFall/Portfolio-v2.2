using System.ComponentModel.DataAnnotations;
using Domain.Models.DAO.INT;

namespace Domain.Models.DAO.SYS;

public class SYS_Langage
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsFramework { get; set; } = false;
    public bool IsSGBD { get; set; } = false;

    public ICollection<INT_ProjectLangage> ProjectLangages { get; set; }
}