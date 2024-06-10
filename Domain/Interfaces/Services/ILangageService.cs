using Domain.Models.DAO.SYS;

namespace Domain.Interfaces.Services;

public interface ILangageService
{
    Task<IEnumerable<SYS_Langage>> GetAllAsync();
    Task<SYS_Langage> GetByIdAsync(int id);
    Task CreateAsync(SYS_Langage langage);
    Task UpdateAsync(SYS_Langage langage);
    Task DeleteAsync(int id);
}