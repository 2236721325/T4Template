using Base.Shared.IServices;
using Testststs.Dtos.UserDtos;

namespace Testststs.IServices
{
    public interface IUserService : ICrudService<Int64, UserDto,
       UserUpdateDto, UserCreateDto>
    {
        
    }
}