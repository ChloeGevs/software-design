using Microsoft.EntityFrameworkCore;
using static lab5.BookStore;

namespace lab5
{
    public class BookstoreContext : DbContext
    {
        // DbSet properties map your C# classes to database tables
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configures the connection to your Local MS SQL database
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BookstoreDB;Trusted_Connection=True;");
        }
    }
}