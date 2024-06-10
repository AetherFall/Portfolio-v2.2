using Domain.Models.DTO.USR;

namespace Domain.Models.DTO.PRO;

public class PRO_CompanyDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    /// <summary>
    /// Logo - Format HTML / SVG
    /// </summary>
    public string? Logo { get; set; }
    public string? LogoBackgroundColor { get; set; }
    public string? Description { get; set; }
    public string? Website { get; set; }
}