using Domain.Models.DAO.INT;

namespace Domain.Models.DTO.SYS;

public class SYS_APIDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? Website { get; set; }
}