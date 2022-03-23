using AutoMapper;
using OSES_DesktopClientServer.DataTransferObjects;
using OSES_DesktopClientServer.Models;

namespace OSES_DesktopClientServer;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDto>()
            .ForMember(dest => dest.FullName,
                src => src.MapFrom(x => x.FirstName + " " + x.LastName));
    }
}