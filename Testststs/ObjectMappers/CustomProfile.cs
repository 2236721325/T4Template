using AutoMapper;
using Testststs.Models;
using Testststs.Dtos.PoemDtos;
using Testststs.Dtos.UserDtos;
using Base.Shared.Commons;

namespace Testststs.ObjectMaps
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
                 .ForMember(d => d.PassHash, f => f
                .MapFrom(e => MD5Helper.MD5Encrypt32(e.Password)));

        }
    }
}
