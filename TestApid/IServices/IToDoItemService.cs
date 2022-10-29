using Base.Shared.IServices;
using TestApid.Dtos.ToDoItemDtos;

namespace TestApid.IServices
{
    public interface IToDoItemService : ICrudService<Int32, ToDoItemDto,
       ToDoItemUpdateDto, ToDoItemCreateDto>
    {
        
    }
}