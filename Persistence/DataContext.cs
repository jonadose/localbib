using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = Guid.NewGuid(),
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    Description = "The Great Gatsby is a 1925 ",
                    Isbn_10 = "0743273567",
                    Isbn_13 = "9780743273565"

                },
                new Book
                {
                    Id = Guid.NewGuid(),
                    Title = "Moby Dick",
                    Author = "Charles Dickens",
                    Description = "Book",
                    Isbn_10 = "1293585899",
                    Isbn_13 = "2958373967392"
                });
        }


        public DbSet<Book> Books { get; set; }
    }
}
