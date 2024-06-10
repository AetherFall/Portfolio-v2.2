using Domain.Interfaces;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Models.DAO.SYS;

namespace Domain.Services;

public class LangageService : ILangageService
{
    private readonly ILangageRepository _repository;

    public LangageService(ILangageRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<IEnumerable<SYS_Langage>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<SYS_Langage> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task CreateAsync(SYS_Langage langage)
    {
        await _repository.CreateAsync(langage);
    }

    public async Task UpdateAsync(SYS_Langage langage)
    {
        await _repository.UpdateAsync(langage);
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }
}