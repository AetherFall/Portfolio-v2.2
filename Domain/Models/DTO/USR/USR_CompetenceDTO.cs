using Domain.Models.DAO.INT;

namespace Domain.Models.DTO.USR;

public class USR_CompetenceDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    /// <summary>
    /// Icon name - Format HTML / SVG
    /// </summary>
    public string Icon { get; set; }
}