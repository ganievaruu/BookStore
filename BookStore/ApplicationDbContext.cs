using Microsoft.EntityFrameworkCore;

namespace BookStore
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public ApplicationDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=../../../../BookStore.db;Cache=Shared");
        }
    }
}
