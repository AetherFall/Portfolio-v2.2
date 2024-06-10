using Domain.Models.DTO.SYS;

namespace Application.Interfaces;

public interface ILangageServiceAppService
{
    Task<IEnumerable<SYS_LangageDTO>> GetAllAsync();
    Task<SYS_LangageDTO> GetByIdAsync(int id);
    Task CreateAsync(SYS_LangageDTO langage);
    Task UpdateAsync(SYS_LangageDTO langage);
    Task DeleteAsync(int id);
}