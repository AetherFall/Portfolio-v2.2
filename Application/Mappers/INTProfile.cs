using AutoMapper;
using Domain.Models.DAO.INT;
using Domain.Models.DTO.INT;
using Domain.Models.DTO.USR;

namespace Application.Mappers;

public class INTProfile : Profile
{
    public INTProfile()
    {
        CreateMap<INT_CompetenceCategory, INT_CompetenceCategoryDTO>().ReverseMap();
        CreateMap<INT_ProjectImage, INT_ProjectImageDTO>().ReverseMap();
        CreateMap<INT_ProjectLink, INT_ProjectLinkDTO>().ReverseMap();
        
        CreateMap<IEnumerable<INT_ProjectLangage>, USR_ProjectDTO>()
            .ForMember(dest => dest.Langages, opt => opt.MapFrom(src => src));
        
        CreateMap<IEnumerable<INT_ProjetAPI>, USR_ProjectDTO>()
            .ForMember(dest => dest.APIs, opt => opt.MapFrom(src => src));
    }
}