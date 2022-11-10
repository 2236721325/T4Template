using System;

namespace TestApid.Dtos
{
    public class ToDoItemDto
    {
        public String Name { get; set; }
        public String? Content { get; set; }
        public Int32? MyProperty { get; set; }
        public Int32 Id { get; set; }
    }

    public class ToDoItemCreateDto
    {
        public String Name { get; set; }
        public String? Content { get; set; }
        public Int32? MyProperty { get; set; }
    }

    public class ToDoItemUpdateDto
    {
        public String Name { get; set; }
        public String? Content { get; set; }
        public Int32? MyProperty { get; set; }
        public Int32 Id { get; set; }
    }

}