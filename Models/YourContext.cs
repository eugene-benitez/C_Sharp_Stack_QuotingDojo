using Microsoft.EntityFrameworkCore;


//CHANGE THIS
namespace C_Sharp.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        // "users" table is represented by this DbSet "Users"
        public DbSet<User> User { get; set; }
        public DbSet<Quote> Quote { get; set; }
        public DbSet<Likes> Likes { get; set; }

    }
}
