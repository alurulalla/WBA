using AutoMapper;
using WBA.API.Dtos;
using WBA.API.Models;

namespace WBA.API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserForRegisterDto, User>();
            CreateMap<User, UserForListDto>();
        }
    }
}