using Base.Shared.Domains;

namespace Testststs.Models
{
    public class Poem:BaseEntity<int>
    {
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
