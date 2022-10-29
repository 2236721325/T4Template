using Base.Shared.Domains;

namespace TestApid.Models
{
    public class ToDoItem:BaseEntity<int>
    {
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
