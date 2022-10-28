using AutoMapper;
using Base.Shared;
using Base.Shared.Dtos;
using Base.Shared.Services;
using TestWebApi.Datas;
using TestWebApi.Dtos.UserDtos;
using TestWebApi.IServices;
using TestWebApi.Models;

namespace TestWebApi.Services
{
    public class UserService : CrudService<User, Int32, 
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