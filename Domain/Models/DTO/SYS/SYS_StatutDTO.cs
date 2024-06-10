namespace Domain.Models.DTO.SYS;

public class SYS_StatutDTO
{
    public string Name { get; set; }
    public bool IsFinished { get; set; } = false;
    public bool IsStarted { get; set; } = false;
    public string? BackgroundColor { get; set; }
    public string? ForegroundColor { get; set; }
}