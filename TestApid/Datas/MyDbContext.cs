using Microsoft.EntityFrameworkCore;
using TestApid.Models;


namespace TestApid.Datas
{
    public class MyDbContext : DbContext
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }




    }
}
