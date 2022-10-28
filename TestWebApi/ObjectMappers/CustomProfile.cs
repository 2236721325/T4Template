using AutoMapper;
using TestWebApi.Models;
using TestWebApi.Dtos.PoemDtos;
using TestWebApi.Dtos.UserDtos;

namespace TestWebApi.ObjectMaps
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
