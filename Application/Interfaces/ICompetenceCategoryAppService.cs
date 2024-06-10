using Domain.Models.DTO.INT;

namespace Application.Interfaces;

public interface ICompetenceCategoryAppService
{
    Task<IEnumerable<INT_CompetenceCategoryDTO>> GetAllAsync();
    Task<INT_CompetenceCategoryDTO> GetByIdAsync(int id);
    Task CreateAsync(INT_CompetenceCategoryDTO dto);
    Task UpdateAsync(INT_CompetenceCategoryDTO dto);
    Task DeleteAsync(int id);
}