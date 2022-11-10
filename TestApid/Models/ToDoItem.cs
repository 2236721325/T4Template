
using WebApi.FreeSqlShared.Domains;

namespace TestApid.Models
{
    public class ToDoItem:BaseEntity<int>
    {
        public string Name { get; set; }
        public string? Content { get; set; }
        public int? MyProperty { get; set; }
    }
}
