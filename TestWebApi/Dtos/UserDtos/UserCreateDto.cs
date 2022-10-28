using System;

namespace TestWebApi.Dtos.UserDtos
{
    public class UserCreateDto
    {
        public String Name { get; set; }
        public String Account { get; set; }
        public String Password { get; set; }
    }
}