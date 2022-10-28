using Base.Shared.Domains;

namespace TestWebApi.Models
{//
    public class Poem:BaseEntity<int>
    {
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
