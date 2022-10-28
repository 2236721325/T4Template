using Base.Shared.Dtos;
using Base.Shared.IControllers;
using Microsoft.AspNetCore.Mvc;
using T4Template.Dtos.HelloDtos;
using T4Template.IServices;
using T4Template.Services;

namespace T4Template.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HelloController : ControllerBase,
        ICrudController<Guid,HelloDto,HelloUpdateDto,
            HelloCreateDto>
    {
        private readonly IHelloService _IHelloService;

        public HelloController(IHelloService iHelloService)
        {
            _IHelloService = iHelloService;
        }

      

        [HttpGet("{id}")]
        public async Task<ApiResult<HelloDto>> Get(Guid id)
        {
            return await _IHelloService.GetAsync(id);
        }

        [HttpPost]
        public async Task<ApiResult<PagedListDto<HelloDto>>> GetPagedList(PagedSearchDto search)
        {
            return await _IHelloService.GetPagedListAsync(search);
        }

        [HttpPost]
        public async Task<ApiResult> Insert(HelloCreateDto dto)
        {
            return await _IHelloService.InsertAsync(dto);
        }

        [HttpPut]
        public async Task<ApiResult> Update(HelloUpdateDto dto)
        {
            return await _IHelloService.UpdateAsync(dto);
        }

        [HttpDelete("{id}")]
        public async Task<ApiResult> Delete(Guid id)
        {
            return await _IHelloService.DeleteAsync(id);
        }
    }
}