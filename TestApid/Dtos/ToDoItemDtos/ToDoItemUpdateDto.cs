using System;

namespace TestApid.Dtos.ToDoItemDtos
{
    public class ToDoItemUpdateDto
    {
        public String Name { get; set; }
        public String Content { get; set; }
        public Int32 Id { get; set; }
    }
}