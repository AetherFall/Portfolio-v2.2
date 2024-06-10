using Domain.Models.DTO.SYS;

namespace Application.Interfaces;

public interface IAPIServiceAppService
{
    Task<IEnumerable<SYS_APIDTO?>> GetAllAsync();
    Task<SYS_APIDTO?> GetByIdAsync(int id);
    Task CreateAsync(SYS_APIDTO? api);
    Task UpdateAsync(SYS_APIDTO api);
    Task DeleteAsync(int id);
}