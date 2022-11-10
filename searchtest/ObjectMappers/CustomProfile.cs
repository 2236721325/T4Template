using AutoMapper;
using searchtest.Models;
using searchtest.Dtos;



namespace searchtest.ObjectMaps
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
