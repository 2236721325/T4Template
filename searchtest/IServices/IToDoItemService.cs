using searchtest.Dtos;
using WebApi.BaseShared.IServices;

namespace searchtest.IServices
{
    public interface IToDoItemService : ICrudService<Guid, ToDoItemDto,
       ToDoItemUpdateDto, ToDoItemCreateDto>
    {
        
    }
}