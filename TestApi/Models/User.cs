using Base.Shared.Domains;

namespace TestApi.Models
{
    public class User:BaseEntity<int>
    {
        public string Name { get; set; }
        public string Account { get; set; }
        public string PassHash { get; set; }
    }
}
