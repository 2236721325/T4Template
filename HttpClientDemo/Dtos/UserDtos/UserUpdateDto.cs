using System;

namespace HttpClientDemo.Dtos.UserDtos
{
    public class UserUpdateDto
    {
        public string Name { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
    }
}