namespace Domain.Models.DTO.INT;

public class INT_ProjectImageDTO
{
    public int Id { get; set; }
    public string Url { get; set; }
    public int? X { get; set; }
    public int? Y { get; set; }
    public int? Width { get; set; }
    public int? Height { get; set; }
    public string? Description { get; set; }
}