using Base.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Shared.IServices
{
    public interface ICrudService<TKey,TEnityDto,TUpdateDto,TCreateDto>
    {
        Task<ApiResult<TEnityDto>> GetAsync(TKey id);
        Task<ApiResult<PagedListDto<TEnityDto>>> GetPagedListAsync(PagedSearchDto search);
        Task<ApiResult> CanInsertAsync(TCreateDto dto);
        Task<ApiResult> InsertAsync(TCreateDto dto);
        Task<ApiResult> CanUpdateAsync(TUpdateDto dto);
        Task<ApiResult> UpdateAsync(TUpdateDto dto);
        Task<ApiResult> DeleteAsync(TKey id);

    }
}
