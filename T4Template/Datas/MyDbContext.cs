using Microsoft.EntityFrameworkCore;
using T4Template.Models;


namespace T4Template.Datas
{
    public class MyDbContext : DbContext
    {
        public DbSet<Hello> Hellos { get; set; }
        public DbSet<User> Users { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }




    }
}
