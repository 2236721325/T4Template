using Base.Shared.Domains;

namespace TestWebApi.Models
{
    public class User:BaseEntity<int>
    {
        public string Name { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
    }
}
