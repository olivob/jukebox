using AutoMapper; 
using Jukebox.Models; 
using Jukebox.DTO;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDTO>();
    }
}