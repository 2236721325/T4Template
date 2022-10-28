using System;

namespace TestWebApi.Dtos.UserDtos
{
    public class UserDto
    {
        public String Name { get; set; }
        public String Account { get; set; }
        public String Password { get; set; }
        public Int32 Id { get; set; }
    }
}