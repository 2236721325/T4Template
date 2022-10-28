using Base.Shared.Domains;

namespace TestApi.Models
{
    public class Poem : BaseEntity<int>
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
