using Microsoft.EntityFrameworkCore;
using TestApi.Models;


namespace TestApi.Datas
{
    public class MyDbContext : DbContext
    {
        public DbSet<Poem> Poems { get; set; }
        public DbSet<User> Users { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }




    }
}
