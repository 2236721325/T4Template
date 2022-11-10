using AutoMapper;
using searchtest.Dtos;
using searchtest.IServices;
using searchtest.Models;
using WebApi.BaseShared;
using WebApi.BaseShared.Dtos;
using WebApi.FreeSqlShared.Services;

namespace searchtest.Services
{
    public class ToDoItemService : CrudService<ToDoItem, Guid, 
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