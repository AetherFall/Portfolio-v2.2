using AutoMapper;
using Domain.Models.DAO.USR;
using Domain.Models.DTO.USR;

namespace Application.Mappers;

public class USRProfile : Profile
{
    public USRProfile()
    {
        CreateMap<USR_Competence, USR_CompetenceDTO>().ReverseMap();
        CreateMap<USR_Contact, USR_ContactDTO>().ReverseMap();
        CreateMap<USR_Experience, USR_ExperienceDTO>().ReverseMap();
        CreateMap<USR_Project, USR_ProjectDTO>().ReverseMap();
    }
}