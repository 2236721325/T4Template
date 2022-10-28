using AutoMapper;
using TestApi.Models;
using TestApi.Dtos.PoemDtos;
using TestApi.Dtos.UserDtos;
using Base.Shared.Commons;

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
            CreateMap<UserCreateDto, User>()
                .ForMember(d => d.PassHash, f => f
                .MapFrom(e => MD5Helper.MD5Encrypt32(e.Password)));

            CreateMap<UserUpdateDto, User>()

        }
    }
}
