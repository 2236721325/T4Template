using AutoMapper;
using Base.Shared;
using Base.Shared.Dtos;
using Base.Shared.Services;
using Testststs.Datas;
using Testststs.Dtos.UserDtos;
using Testststs.IServices;
using Testststs.Models;

namespace Testststs.Services
{
    public class UserService : CrudService<User, Int64, 
        UserDto, UserUpdateDto, UserCreateDto>,
        IUserService,
        ITransientDependency
    {
        public UserService(MyDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public override async Task<ApiResult> CanInsertAsync(UserCreateDto dto)
        {
            if (_Enitity.Any(e => e.Account == dto.Account)) return await Task.FromResult(ApiResult.OhNo("用户名已经存在!"));
            return await Task.FromResult(ApiResult.Ok());          
        }

        public override async Task<ApiResult> CanUpdateAsync(UserUpdateDto dto)
        {
            return await Task.FromResult(ApiResult.Ok());          
        }
    }
}