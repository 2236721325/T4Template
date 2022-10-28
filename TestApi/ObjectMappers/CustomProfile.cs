using AutoMapper;
using TestApi.Models;
using TestApi.Dtos.PoemDtos;
using TestApi.Dtos.UserDtos;

namespace TestApi.ObjectMaps
{
    public class CustomProfile:Profile
    {
        public CustomProfile()
        {
            CreateMap<Poem, PoemDto>();
            CreateMap<PoemCreateDto, Poem>();
            CreateMap<PoemUpdateDto, Poem>();
            CreateMap<User, UserDto>();
            CreateMap<UserCreateDto, User>();
            CreateMap<UserUpdateDto, User>();

        }
    }
}
