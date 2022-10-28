using System;

namespace TestApi.Dtos.UserDtos
{
    public class UserDto
    {
        public String Name { get; set; }
        public String Account { get; set; }
        public String PassHash { get; set; }
        public Int32 Id { get; set; }
    }
}