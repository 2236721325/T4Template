using Base.Shared.IServices;
using T4Template.Dtos.UserDtos;

namespace T4Template.IServices
{
    public interface IUserService : ICrudService<Guid, UserDto,
       UserUpdateDto, UserCreateDto>
    {
        
    }
}