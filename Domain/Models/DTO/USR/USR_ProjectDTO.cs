using Domain.Models.DTO.INT;
using Domain.Models.DTO.PRO;
using Domain.Models.DTO.SYS;

namespace Domain.Models.DTO.USR;

public class USR_ProjectDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DateDebut { get; set; }
    public DateTime DateFin { get; set; }
    public string Statut { get; set; }
    public string Logo { get; set; }
    public bool IsActive { get; set; }
    public string NoteClient { get; set; }
    
    public PRO_CompanyDTO? Company { get; set; }
    public List<SYS_APIDTO> APIs { get; set; } = new();
    public List<SYS_LangageDTO> Langages { get; set; } = new();
    public List<INT_ProjectImageDTO> Images { get; set; } = new();
    public List<INT_ProjectLinkDTO> Links { get; set; } = new();
}