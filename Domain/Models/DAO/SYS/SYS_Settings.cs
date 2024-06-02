using System.ComponentModel.DataAnnotations;

namespace Domain.Models.DAO.SYS;

public class SYS_Settings
{
    [Key]
    public string Name { get; set; }
    public string Value { get; set; }
}