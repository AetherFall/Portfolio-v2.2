using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.DAO.SYS;

public class SYS_NavBar
{
    [Key] 
    public string Name { get; set; }
    public string? Url { get; set; }
    public bool IsHome { get; set; } = false;
}