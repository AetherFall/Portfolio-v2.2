using Application.Interfaces;
using AutoMapper;
using Domain.Interfaces.Services;
using Domain.Models.DAO.SYS;
using Domain.Models.DTO.SYS;

namespace Application.Services;

public class LangageServiceAppService : ILangageServiceAppService
{
    private readonly ILangageService _service;
    private readonly IMapper _mapper;

    public LangageServiceAppService(ILangageService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    public async Task<IEnumerable<SYS_LangageDTO>> GetAllAsync()
    {
        var langages = await _service.GetAllAsync();
        return _mapper.Map<IEnumerable<SYS_LangageDTO>>(langages);
    }

    public async Task<SYS_LangageDTO> GetByIdAsync(int id)
    {
        var langage = await _service.GetByIdAsync(id);
        return _mapper.Map<SYS_LangageDTO>(langage);
    }

    public async Task CreateAsync(SYS_LangageDTO langage)
    {
        var langDAO = _mapper.Map<SYS_Langage>(langage);
        await _service.CreateAsync(langDAO);
    }

    public async Task UpdateAsync(SYS_LangageDTO langage)
    {
        var langDAO = _mapper.Map<SYS_Langage>(langage);
        await _service.UpdateAsync(langDAO);
    }

    public async Task DeleteAsync(int id)
    {
        await _service.DeleteAsync(id);
    }
}