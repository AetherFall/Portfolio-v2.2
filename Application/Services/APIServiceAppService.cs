using Application.Interfaces;
using AutoMapper;
using Domain.Interfaces.Services;
using Domain.Models.DAO.SYS;
using Domain.Models.DTO.SYS;

namespace Application.Services;

public class APIServiceAppService : IAPIServiceAppService
{
    private readonly IAPIService _service;
    private readonly IMapper _mapper;

    public APIServiceAppService(IAPIService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    public async Task<IEnumerable<SYS_APIDTO?>> GetAllAsync()
    {
        var apis = await _service.GetAllAsync();
        return _mapper.Map<IEnumerable<SYS_APIDTO?>>(apis);
    }

    public async Task<SYS_APIDTO?> GetByIdAsync(int id)
    {
        var api = await _service.GetByIdAsync(id);
        return _mapper.Map<SYS_APIDTO?>(api);
    }

    public async Task CreateAsync(SYS_APIDTO? api)
    {
        var apiDAO = _mapper.Map<SYS_API>(api);
        await _service.CreateAsync(apiDAO);
    }

    public async Task UpdateAsync(SYS_APIDTO api)
    {
        var apiDAO = _mapper.Map<SYS_API>(api);
        await _service.UpdateAsync(apiDAO);
    }

    public async Task DeleteAsync(int id)
    {
        await _service.DeleteAsync(id);
    }
}