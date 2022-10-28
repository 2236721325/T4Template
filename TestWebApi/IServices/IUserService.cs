using Base.Shared.IServices;
using TestWebApi.Dtos.UserDtos;

namespace TestWebApi.IServices
{
    public interface IUserService : ICrudService<Int32, UserDto,
       UserUpdateDto, UserCreateDto>
    {
        
    }
}