using System;

namespace TestWebApi.Dtos.PoemDtos
{
    public class PoemUpdateDto
    {
        public String Name { get; set; }
        public String Content { get; set; }
        public Int32 Id { get; set; }
    }
}