using WebApi.FreeSqlShared.Domains;
namespace searchtest.Models
{
    public class ToDoItem: BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
