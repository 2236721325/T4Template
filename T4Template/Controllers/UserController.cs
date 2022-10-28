using Base.Shared.Dtos;
using Base.Shared.IControllers;
using Microsoft.AspNetCore.Mvc;
using T4Template.Dtos.UserDtos;
using T4Template.IServices;
using T4Template.Services;

namespace T4Template.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase,
        ICrudController<Guid,UserDto,UserUpdateDto,
            UserCreateDto>
    {
        private readonly IUserService _IUserService;

        public UserController(IUserService iUserService)
        {
            _IUserService = iUserService;
        }

      

        [HttpGet("{id}")]
        public async Task<ApiResult<UserDto>> Get(Guid id)
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
        public async Task<ApiResult> Delete(Guid id)
        {
            return await _IUserService.DeleteAsync(id);
        }
    }
}