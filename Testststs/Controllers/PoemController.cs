using Base.Shared.Dtos;
using Base.Shared.IControllers;
using Microsoft.AspNetCore.Mvc;
using Testststs.Dtos.PoemDtos;
using Testststs.IServices;
using Testststs.Services;

namespace Testststs.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PoemController : ControllerBase,
        ICrudController<Int32,PoemDto,PoemUpdateDto,
            PoemCreateDto>
    {
        private readonly IPoemService _IPoemService;

        public PoemController(IPoemService iPoemService)
        {
            _IPoemService = iPoemService;
        }

      

        [HttpGet("{id}")]
        public async Task<ApiResult<PoemDto>> Get(Int32 id)
        {
            return await _IPoemService.GetAsync(id);
        }

        [HttpPost]
        public async Task<ApiResult<PagedListDto<PoemDto>>> GetPagedList(PagedSearchDto search)
        {
            return await _IPoemService.GetPagedListAsync(search);
        }

        [HttpPost]
        public async Task<ApiResult> Insert(PoemCreateDto dto)
        {
            return await _IPoemService.InsertAsync(dto);
        }

        [HttpPut]
        public async Task<ApiResult> Update(PoemUpdateDto dto)
        {
            return await _IPoemService.UpdateAsync(dto);
        }

        [HttpDelete("{id}")]
        public async Task<ApiResult> Delete(Int32 id)
        {
            return await _IPoemService.DeleteAsync(id);
        }
    }
}