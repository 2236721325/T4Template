using Microsoft.EntityFrameworkCore;
using Testststs.Models;


namespace Testststs.Datas
{
    public class MyDbContext : DbContext
    {
        public DbSet<Poem> Poems { get; set; }
        public DbSet<User> Users { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }




    }
}
