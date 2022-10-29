using AutoMapper;
using Base.Shared;
using Base.Shared.Dtos;
using Base.Shared.Services;
using TestApid.Datas;
using TestApid.Dtos.ToDoItemDtos;
using TestApid.IServices;
using TestApid.Models;

namespace TestApid.Services
{
    public class ToDoItemService : CrudService<ToDoItem, Int32, 
        ToDoItemDto, ToDoItemUpdateDto, ToDoItemCreateDto>,
        IToDoItemService,
        ITransientDependency
    {
        public ToDoItemService(MyDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
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