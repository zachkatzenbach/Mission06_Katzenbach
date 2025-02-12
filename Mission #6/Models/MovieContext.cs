using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace Mission__6.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options)
        { 
        }

        public DbSet<Movie> Applications { get; set; }
    }
}
