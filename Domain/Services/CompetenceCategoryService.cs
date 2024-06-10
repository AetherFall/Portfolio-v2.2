using Domain.Interfaces;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Models.DAO.INT;

namespace Domain.Services;

public class CompetenceCategoryService : ICompetenceCategoryService
{
    private readonly ICompetenceCategoryRepository _repository;

    public CompetenceCategoryService(ICompetenceCategoryRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<INT_CompetenceCategory?>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<INT_CompetenceCategory?> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task CreateAsync(INT_CompetenceCategory category)
    {
        await _repository.AddAsync(category);
    }

    public async Task UpdateAsync(INT_CompetenceCategory category)
    {
        await _repository.UpdateAsync(category);
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }
}
