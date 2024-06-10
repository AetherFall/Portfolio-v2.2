using Domain.Models.DTO.PRO;

namespace Application.Interfaces;

public interface ICompanyServiceAppService
{
    Task<IEnumerable<PRO_CompanyDTO?>> GetAllAsync();
    Task<PRO_CompanyDTO?> GetByIdAsync(int id);
    Task CreateAsync(PRO_CompanyDTO? company);
    Task UpdateAsync(PRO_CompanyDTO company);
    Task DeleteAsync(int id);
}