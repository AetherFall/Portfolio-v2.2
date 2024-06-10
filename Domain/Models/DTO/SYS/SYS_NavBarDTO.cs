namespace Domain.Models.DTO.SYS;

public class SYS_NavBarDTO
{
    public string Name { get; set; }
    public string? Url { get; set; }
    public bool IsHome { get; set; } = false;
}