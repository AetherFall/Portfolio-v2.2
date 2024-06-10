using Domain.Models.DAO.INT;

namespace Domain.Models.DTO.SYS;

public class SYS_LangageDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsFramework { get; set; } = false;
    public bool IsSGBD { get; set; } = false;
}