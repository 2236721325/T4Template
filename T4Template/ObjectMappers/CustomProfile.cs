using AutoMapper;
using T4Template.Models;
using T4Template.Dtos.HelloDtos;
using T4Template.Dtos.UserDtos;

namespace T4Template.ObjectMaps
{
    public class CustomProfile:Profile
    {
        public CustomProfile()
        {
            CreateMap<Hello, HelloDto>();
            CreateMap<HelloCreateDto, Hello>();
            CreateMap<HelloUpdateDto, Hello>();
            CreateMap<User, UserDto>();
            CreateMap<UserCreateDto, User>();
            CreateMap<UserUpdateDto, User>();
        }
    }
}
