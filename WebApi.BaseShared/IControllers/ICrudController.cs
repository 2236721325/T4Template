using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.BaseShared.Dtos;

namespace WebApi.BaseShared.IControllers
{
    public interface ICrudController<TKey, TEnityDto, TUpdateDto, TCreateDto>
    {
        Task<ApiResult<TEnityDto>> Get(TKey id);
        Task<ApiResult<PagedListDto<TEnityDto>>> GetPagedList(PagedSearchDto getPaged);
        Task<ApiResult> Insert(TCreateDto create);
        Task<ApiResult> Update(TUpdateDto update);
        Task<ApiResult> Delete(TKey id);
    }
}
