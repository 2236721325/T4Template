using WebApi.BaseShared.IServices;
using TestApid.Dtos;

namespace TestApid.IServices
{
    public interface IToDoItemService : ICrudService<Int32, ToDoItemDto,
       ToDoItemUpdateDto, ToDoItemCreateDto>
    {
        
    }
}