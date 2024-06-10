using Application.Interfaces;
using AutoMapper;
using Domain.Interfaces.Services;
using Domain.Models.DAO.INT;
using Domain.Models.DTO.INT;

namespace Application.Services;

public class CompetenceCategoryAppService : ICompetenceCategoryAppService
{
    private readonly ICompetenceCategoryService _service;
    private readonly IMapper _mapper;

    public CompetenceCategoryAppService(ICompetenceCategoryService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    public async Task<IEnumerable<INT_CompetenceCategoryDTO>> GetAllAsync()
    {
        var categories = await _service.GetAllAsync();
        return _mapper.Map<IEnumerable<INT_CompetenceCategoryDTO>>(categories);
    }

    public async Task<INT_CompetenceCategoryDTO> GetByIdAsync(int id)
    {
        var category = await _service.GetByIdAsync(id);
        if (category == null) return null;

        return _mapper.Map<INT_CompetenceCategoryDTO>(category);
    }

    public async Task CreateAsync(INT_CompetenceCategoryDTO dto)
    {
        var category = _mapper.Map<INT_CompetenceCategory>(dto);
        await _service.CreateAsync(category);
    }

    public async Task UpdateAsync(INT_CompetenceCategoryDTO dto)
    {
        var category = _mapper.Map<INT_CompetenceCategory>(dto);
        await _service.UpdateAsync(category);
    }

    public async Task DeleteAsync(int id)
    {
        await _service.DeleteAsync(id);
    }
}
