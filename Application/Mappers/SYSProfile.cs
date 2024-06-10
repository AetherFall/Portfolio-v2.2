using AutoMapper;
using Domain.Models.DAO.SYS;
using Domain.Models.DTO.SYS;

namespace Application.Mappers;

public class SYSProfile : Profile
{
    public SYSProfile()
    {
        CreateMap<SYS_API, SYS_APIDTO>().ReverseMap();
        CreateMap<SYS_Langage, SYS_LangageDTO>().ReverseMap();
        CreateMap<SYS_NavBar, SYS_NavBarDTO>().ReverseMap();
        CreateMap<SYS_Settings, SYS_SettingsDTO>().ReverseMap();
        CreateMap<SYS_Statut, SYS_StatutDTO>().ReverseMap();
    }
}