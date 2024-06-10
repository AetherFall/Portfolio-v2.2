using Domain.Models.DAO.PRO;

namespace Domain.Interfaces;

public interface ICompanyRepository
{
    Task<IEnumerable<PRO_Company?>> GetAllAsync();
    Task<PRO_Company?> GetByIdAsync(int id);
    Task CreateAsync(PRO_Company? company);
    Task UpdateAsync(PRO_Company company);
    Task DeleteAsync(int id);
}
