using AutoMapper;
using TestApid.Models;
using TestApid.Dtos.ToDoItemDtos;

namespace TestApid.ObjectMaps
{
    public class CustomProfile:Profile
    {
        public CustomProfile()
        {
            CreateMap<ToDoItem, ToDoItemDto>();
            CreateMap<ToDoItemCreateDto, ToDoItem>();
            CreateMap<ToDoItemUpdateDto, ToDoItem>();

        }
    }
}
