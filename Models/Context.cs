using Microsoft.EntityFrameworkCore;

namespace Wedding_Site.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }

        public DbSet<Guest> Guests { get; set; }
    }
}