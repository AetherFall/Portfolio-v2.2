using AutoMapper;
using Domain.Models.DAO.PRO;
using Domain.Models.DTO.PRO;

namespace Application.Mappers;

public class PROProfile : Profile
{
    public PROProfile()
    {
        CreateMap<PRO_Company, PRO_CompanyDTO>().ReverseMap();
    }
}