using System;

namespace HttpClientDemo.Dtos.UserDtos
{
    public class UserCreateDto
    {
        public string Name { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
    }
}