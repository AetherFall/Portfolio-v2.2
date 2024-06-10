using Domain.Interfaces;
using Domain.Interfaces.Services;
using Domain.Models.DAO.PRO;

namespace Domain.Services;

public class CompanyService : ICompanyService
{
    private readonly ICompanyRepository _repository;

    public CompanyService(ICompanyRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<PRO_Company?>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<PRO_Company?> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task CreateAsync(PRO_Company? company)
    {
        await _repository.CreateAsync(company);
    }

    public async Task UpdateAsync(PRO_Company company)
    {
        await _repository.UpdateAsync(company);
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }
}