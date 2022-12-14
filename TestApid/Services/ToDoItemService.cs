using AutoMapper;
using WebApi.BaseShared;
using WebApi.BaseShared.Dtos;
using WebApi.FreeSqlShared.Services;
using WebApi.FreeSqlShared.Domains;

using TestApid.Dtos;
using TestApid.IServices;
using TestApid.Models;

namespace TestApid.Services
{
    public class ToDoItemService : CrudService<ToDoItem, Int32, 
        ToDoItemDto, ToDoItemUpdateDto, ToDoItemCreateDto>,
        IToDoItemService,
        ITransientDependency
    {
        public ToDoItemService(IMapper mapper, IFreeSql freeSql) : base(mapper, freeSql)
        {
        }

        public override async Task<ApiResult> CanInsertAsync(ToDoItemCreateDto dto)
        {
            return await Task.FromResult(ApiResult.Ok());          
        }

        public override async Task<ApiResult> CanUpdateAsync(ToDoItemUpdateDto dto)
        {
            return await Task.FromResult(ApiResult.Ok());          
        }
    }
}