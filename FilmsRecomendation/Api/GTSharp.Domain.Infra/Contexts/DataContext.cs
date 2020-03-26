using GTSharp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GTSharp.Domain.Infra.Contexts
{
    public class DataContext : DbContext
    {
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Overview> Overview { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    }
}