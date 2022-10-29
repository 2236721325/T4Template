using System;

namespace HttpClientDemo.Dtos.PoemDtos
{
    public class PoemUpdateDto
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public int Id { get; set; }
    }
}