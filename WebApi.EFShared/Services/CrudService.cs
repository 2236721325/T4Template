using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using WebApi.BaseShared.Commons;
using WebApi.BaseShared.Dtos;
using WebApi.BaseShared.IServices;
using WebApi.EFShared.Domains;

namespace WebApi.EFShared.Services
{
    public abstract class CrudService<TEnity, TKey, TEnityDto,
        TUpdateDto, TCreateDto> :
        ICrudService<TKey, TEnityDto,
        TUpdateDto, TCreateDto> where TEnity : BaseEntity<TKey>
    {
        public DbContext _DbContext { get; set; }
        public DbSet<TEnity> _Enitity { get; set; }
        public IMapper _Mapper { get; set; }

        public CrudService(DbContext dbContext, IMapper mapper)
        {
            _DbContext = dbContext;
            _Enitity = dbContext.Set<TEnity>();
            _Mapper = mapper;
        }




        public async virtual Task<ApiResult> DeleteAsync(TKey id)
        {
            var e = await _Enitity.FindAsync(id);
            if (e == null) return ApiResult.OhNo("Id不存在！");
            _Enitity.Remove(e);
            await _DbContext.SaveChangesAsync();
            return ApiResult.Ok("删除成功");

        }

        public async virtual Task<ApiResult<TEnityDto>> GetAsync(TKey id)
        {
            var e = await _Enitity.FindAsync(id);
            if (e == null) return ApiResult.OhNo<TEnityDto>("Id不存在！");
            return ApiResult.Ok(_Mapper.Map<TEnity, TEnityDto>(e));
        }
        /// <summary>
        /// 这样会sql注入 感觉不会！传入的也是属性的 名称 与数据库无关
        ///
        /// </summary>
        /// <param name="getPaged"></param>
        /// <returns></returns>
        public async virtual Task<ApiResult<PagedListDto<TEnityDto>>> GetPagedListAsync(PagedSearchDto getPaged)
        {
            var query = _Enitity.AsQueryable();
            if (getPaged.Searchs != null)
            {
                var filter = new FilterBuilder();
                //var filter = new StringBuilder();
                foreach (var search in getPaged.Searchs)
                {
                    switch (search.Value.ValueKind)
                    {
                        case JsonValueKind.String:
                            filter.And($"{search.Key}.Contains(\"{search.Value}\")");
                            break;
                        case JsonValueKind.Number:
                            filter.And($"{search.Key}=={search.Value}");
                            break;
                        default:
                            return ApiResult.OhNo<PagedListDto<TEnityDto>>("参数错误:Search错误！");
                    }
                }
                query = _Enitity.Where(filter.Build());


            }
            var count = await query.LongCountAsync();

            var enities = await query.OrderBy(e => e.Id).Skip(getPaged.SkipCount).Take(getPaged.TakeCount).ToListAsync();
            var dtos = _Mapper.Map<List<TEnity>, List<TEnityDto>>(enities);
            return ApiResult.Ok(new PagedListDto<TEnityDto>(dtos, count));
        }

        public abstract Task<ApiResult> CanInsertAsync(TCreateDto dto);

        public async virtual Task<ApiResult> InsertAsync(TCreateDto dto)
        {
            var r = await CanInsertAsync(dto);
            if (r.Status == false) return r;
            var entity = _Mapper.Map<TCreateDto, TEnity>(dto);
            await _Enitity.AddAsync(entity);
            await _DbContext.SaveChangesAsync();
            return ApiResult.Ok("插入成功！");
        }

        public async virtual Task<ApiResult> UpdateAsync(TUpdateDto dto)
        {
            var r = await CanUpdateAsync(dto);
            if (r.Status == false) return r;
            var entity = _Mapper.Map<TUpdateDto, TEnity>(dto);
            _Enitity.Update(entity);
            await _DbContext.SaveChangesAsync();
            return ApiResult.Ok("修改成功！");
        }



        public abstract Task<ApiResult> CanUpdateAsync(TUpdateDto dto);

    }
}
