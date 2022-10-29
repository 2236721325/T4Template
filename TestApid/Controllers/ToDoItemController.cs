using Base.Shared.Dtos;
using Base.Shared.IControllers;
using Microsoft.AspNetCore.Mvc;
using TestApid.Dtos.ToDoItemDtos;
using TestApid.IServices;
using TestApid.Services;

namespace TestApid.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ToDoItemController : ControllerBase,
        ICrudController<Int32,ToDoItemDto,ToDoItemUpdateDto,
            ToDoItemCreateDto>
    {
        private readonly IToDoItemService _IToDoItemService;

        public ToDoItemController(IToDoItemService iToDoItemService)
        {
            _IToDoItemService = iToDoItemService;
        }

      

        [HttpGet("{id}")]
        public async Task<ApiResult<ToDoItemDto>> Get(Int32 id)
        {
            return await _IToDoItemService.GetAsync(id);
        }

        [HttpPost]
        public async Task<ApiResult<PagedListDto<ToDoItemDto>>> GetPagedList(PagedSearchDto search)
        {
            return await _IToDoItemService.GetPagedListAsync(search);
        }

        [HttpPost]
        public async Task<ApiResult> Insert(ToDoItemCreateDto dto)
        {
            return await _IToDoItemService.InsertAsync(dto);
        }

        [HttpPut]
        public async Task<ApiResult> Update(ToDoItemUpdateDto dto)
        {
            return await _IToDoItemService.UpdateAsync(dto);
        }

        [HttpDelete("{id}")]
        public async Task<ApiResult> Delete(Int32 id)
        {
            return await _IToDoItemService.DeleteAsync(id);
        }
    }
}