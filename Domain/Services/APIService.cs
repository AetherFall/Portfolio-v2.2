using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Models.DAO.SYS;

namespace Domain.Services;

public class APIService : IAPIService
{
    private readonly IAPIRepository _repository;

    public APIService(IAPIRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<IEnumerable<SYS_API?>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<SYS_API?> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task CreateAsync(SYS_API? api)
    {
        await _repository.CreateAsync(api);
    }

    public async Task UpdateAsync(SYS_API api)
    {
        await _repository.UpdateAsync(api);
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }
}