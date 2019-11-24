using Microsoft.EntityFrameworkCore;

namespace CrudTest.Db
{
    public class CrudTestDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public CrudTestDbContext(DbContextOptions<CrudTestDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "jlennon",
                    RealName = "John Lennon",
                    Email = "john@beatles.com",
                },
                new User
                {
                    Id = 2,
                    Name = "paulm",
                    RealName = "Paul McCartney",
                    Email = "paul@beatles.com",
                },
                new User
                {
                    Id = 3,
                    Name = "gharrison",
                    RealName = "George Harrison",
                    Email = "george@beatles.com",
                },
                new User
                {
                    Id = 4,
                    Name = "rstarr",
                    RealName = "Richard Starkey",
                    Email = "ringo@beatles.com"
                }
            );
        }
    }
}
