using AutoMapper;
using Base.Shared;
using Base.Shared.Dtos;
using Base.Shared.Services;
using T4Template.Datas;
using T4Template.Dtos.UserDtos;
using T4Template.IServices;
using T4Template.Models;

namespace T4Template.Services
{
    public class UserService : CrudService<User, Guid, 
        UserDto, UserUpdateDto, UserCreateDto>,
        IUserService,
        ITransientDependency
    {
        public UserService(MyDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public override async Task<ApiResult> CanInsertAsync(UserCreateDto dto)
        {
            return await Task.FromResult(ApiResult.Ok());          
        }

        public override async Task<ApiResult> CanUpdateAsync(UserUpdateDto dto)
        {
            return await Task.FromResult(ApiResult.Ok());          
        }
    }
}