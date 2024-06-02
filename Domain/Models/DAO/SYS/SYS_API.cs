using System.ComponentModel.DataAnnotations;
using Domain.Models.DAO.INT;

namespace Domain.Models.DAO.SYS;

public class SYS_API
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? Website { get; set; }

    public ICollection<INT_ProjetAPI> ProjectAPIs { get; set; }
}