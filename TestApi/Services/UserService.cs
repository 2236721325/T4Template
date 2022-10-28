using AutoMapper;
using Base.Shared;
using Base.Shared.Commons;
using Base.Shared.Dtos;
using Base.Shared.Services;
using TestApi.Datas;
using TestApi.Dtos.UserDtos;
using TestApi.IServices;
using TestApi.Models;

namespace TestApi.Services
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
            if(_Enitity.Any(e => e.Account == dto.Account))
            {
                return await Task.FromResult(ApiResult.OhNo("’À∫≈“—æ≠¥Ê‘⁄£°"));
            }
            return await Task.FromResult(ApiResult.Ok());

        }

        public override async Task<ApiResult> CanUpdateAsync(UserUpdateDto dto)
        {
            return await Task.FromResult(ApiResult.Ok());          
        }
    }
}