using Domain.Models.DAO.PRO;
using Domain.Models.DTO.PRO;

namespace Domain.Models.DTO.USR;

public class USR_ExperienceDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public DateTime? DateDebut { get; set; }
    public DateTime? DateFin { get; set; }
    public bool IsCurrent { get; set; } = false;
    public bool IsActive { get; set; } = true;
    public PRO_CompanyDTO Company { get; set; }
}