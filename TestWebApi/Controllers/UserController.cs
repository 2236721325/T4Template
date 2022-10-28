using Base.Shared.Dtos;
using Base.Shared.IControllers;
using Microsoft.AspNetCore.Mvc;
using TestWebApi.Dtos.UserDtos;
using TestWebApi.IServices;
using TestWebApi.Services;

namespace TestWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase,
        ICrudController<Int32,UserDto,UserUpdateDto,
            UserCreateDto>
    {
        private readonly IUserService _IUserService;

        public UserController(IUserService iUserService)
        {
            _IUserService = iUserService;
        }

      

        [HttpGet("{id}")]
        public async Task<ApiResult<UserDto>> Get(Int32 id)
        {
            return await _IUserService.GetAsync(id);
        }

        [HttpPost]
        public async Task<ApiResult<PagedListDto<UserDto>>> GetPagedList(PagedSearchDto search)
        {
            return await _IUserService.GetPagedListAsync(search);
        }

        [HttpPost]
        public async Task<ApiResult> Insert(UserCreateDto dto)
        {
            return await _IUserService.InsertAsync(dto);
        }

        [HttpPut]
        public async Task<ApiResult> Update(UserUpdateDto dto)
        {
            return await _IUserService.UpdateAsync(dto);
        }

        [HttpDelete("{id}")]
        public async Task<ApiResult> Delete(Int32 id)
        {
            return await _IUserService.DeleteAsync(id);
        }
    }
}