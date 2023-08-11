using Microsoft.EntityFrameworkCore;
using MyAPI.Models;
namespace MyAPI.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }
        public DbSet<Business> Businesses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Business>().HasData(
                new Business { Id = 1, Name = "NotUnicornable", SeedCapital=1000m },
                new Business { Id = 2, Name = "Unicornify", SeedCapital=2000m }
            );
        }
    }
}