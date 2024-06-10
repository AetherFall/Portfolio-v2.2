using Domain.Models.DAO.INT;

namespace Domain.Interfaces.Services;

public interface ICompetenceCategoryService
{
    Task<IEnumerable<INT_CompetenceCategory?>> GetAllAsync();
    Task<INT_CompetenceCategory?> GetByIdAsync(int id);
    Task CreateAsync(INT_CompetenceCategory category);
    Task UpdateAsync(INT_CompetenceCategory category);
    Task DeleteAsync(int id);
}