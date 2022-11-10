using System;

namespace searchtest.Dtos
{
    public class ToDoItemDto
    {
        public String Name { get; set; }
        public String Content { get; set; }
        public Guid Id { get; set; }
    }

    public class ToDoItemCreateDto
    {
        public String Name { get; set; }
        public String Content { get; set; }
    }

    public class ToDoItemUpdateDto
    {
        public String Name { get; set; }
        public String Content { get; set; }
        public Guid Id { get; set; }
    }

}