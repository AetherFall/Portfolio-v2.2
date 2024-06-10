using Application.Interfaces;
using AutoMapper;
using Domain.Interfaces.Services;
using Domain.Models.DAO.PRO;
using Domain.Models.DTO.PRO;

namespace Application.Services;

public class CompanyServiceAppService : ICompanyServiceAppService
{
    private readonly ICompanyService _service;
    private readonly IMapper _mapper;

    public CompanyServiceAppService(ICompanyService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<PRO_CompanyDTO?>> GetAllAsync()
    {
        var companies = await _service.GetAllAsync();
        return _mapper.Map<IEnumerable<PRO_CompanyDTO?>>(companies);
    }

    public async Task<PRO_CompanyDTO?> GetByIdAsync(int id)
    {
        var company = await _service.GetByIdAsync(id);
        return _mapper.Map<PRO_CompanyDTO?>(company);
    }

    public async Task CreateAsync(PRO_CompanyDTO? company)
    {
        var companyDAO = _mapper.Map<PRO_Company>(company);
        await _service.CreateAsync(companyDAO);
    }

    public async Task UpdateAsync(PRO_CompanyDTO company)
    {
        var companyDAO = _mapper.Map<PRO_Company>(company);
        await _service.UpdateAsync(companyDAO);
    }

    public async Task DeleteAsync(int id)
    {
        await _service.DeleteAsync(id);
    }
}