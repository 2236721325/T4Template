using Base.Shared.IServices;
using TestApi.Dtos.UserDtos;

namespace TestApi.IServices
{
    public interface IUserService : ICrudService<Int32, UserDto,
       UserUpdateDto, UserCreateDto>1
    {
        
    }
}