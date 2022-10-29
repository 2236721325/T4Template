using Base.Shared.Domains;

namespace Testststs.Models
{
    public class User:BaseEntity<long>
    {
        public string Name { get; set; }
        public string Account { get; set; }
        public string PassHash { get; set; }
    }
}
