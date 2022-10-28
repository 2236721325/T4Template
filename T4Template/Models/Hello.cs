using Base.Shared.Domains;

namespace T4Template.Models
{
    public class Hello : BaseEntity<Guid>
    {
        public string Account { get; set; }
        public string Name { get; set; }
    }
}
