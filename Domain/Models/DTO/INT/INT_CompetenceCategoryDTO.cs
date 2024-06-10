using Domain.Models.DTO.USR;

namespace Domain.Models.DTO.INT;

public class INT_CompetenceCategoryDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? BackgroundColor { get; set; }
    public string? ForegroundColor { get; set; }
    public bool IsSoftwareSkill { get; set; } = true;
    public List<USR_CompetenceDTO> lstCompetences { get; set; }
}