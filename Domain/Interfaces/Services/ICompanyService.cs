using Domain.Models.DAO.PRO;
using Domain.Models.DTO.PRO;

namespace Domain.Interfaces.Services;

public interface ICompanyService
{
    Task<IEnumerable<PRO_Company?>> GetAllAsync();
    Task<PRO_Company?> GetByIdAsync(int id);
    Task CreateAsync(PRO_Company? company);
    Task UpdateAsync(PRO_Company company);
    Task DeleteAsync(int id);
}