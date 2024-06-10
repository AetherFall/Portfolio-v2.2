using Domain.Models.DAO.SYS;

namespace Domain.Interfaces.Services;

public interface IAPIService
{
    Task<IEnumerable<SYS_API?>> GetAllAsync();
    Task<SYS_API?> GetByIdAsync(int id);
    Task CreateAsync(SYS_API? api);
    Task UpdateAsync(SYS_API api);
    Task DeleteAsync(int id);
}