using System.ComponentModel.DataAnnotations;

namespace Domain.Models.DAO.SYS;

public class SYS_Statut
{
    [Key]
    public string Name { get; set; }

    public bool IsFinished { get; set; } = false;
    public bool IsStarted { get; set; } = false;
    
    [MaxLength(7)]
    public string? BackgroundColor { get; set; }
    
    [MaxLength(7)]
    public string? ForegroundColor { get; set; }
}