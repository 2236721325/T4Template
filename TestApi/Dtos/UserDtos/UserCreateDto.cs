using System;

namespace TestApi.Dtos.UserDtos
{
    public class UserCreateDto
    {
        public String Name { get; set; }
        public String Account { get; set; }
        public String PassHash { get; set; }
    }
}