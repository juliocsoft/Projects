using GTSharp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GTSharp.Domain.Infra.Contexts
{
    public class DataContext : DbContext
    {
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Genre> Genre { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Movie>().ToTable("Movie");
        //     modelBuilder.Entity<Movie>().Property(x => x.IdMovie);
        //     modelBuilder.Entity<Movie>().Property(x => x.Budget);
        //     modelBuilder.Entity<Movie>().Property(x => x.OriginalTitle).HasColumnType("varchar(300)");
        //     modelBuilder.Entity<Movie>().Property(x => x.Overview);
        //     modelBuilder.Entity<Movie>().Property(x => x.Popularity);
        //     modelBuilder.Entity<Movie>().Property(x => x.PosterPath).HasColumnType("varchar(200)");
        //     modelBuilder.Entity<Movie>().Property(x => x.ReleaseDate);
        //     modelBuilder.Entity<Movie>().Property(x => x.VoteAverage);
        //     modelBuilder.Entity<Movie>().Property(x => x.VoteCount);
        //     modelBuilder.Entity<Movie>().HasKey(k => k.IdMovie);
        //     modelBuilder.Entity<Movie>().HasIndex(b => b.OriginalTitle);
        
        //     modelBuilder.Entity<Genre>().ToTable("Genre");
        //     modelBuilder.Entity<Genre>().Property(x => x.IdGenre);
        //     modelBuilder.Entity<Genre>().Property(x => x.Name).HasColumnType("varchar(200)");
        //     modelBuilder.Entity<Genre>().Property(x => x.IdMovie);
        //     modelBuilder.Entity<Genre>().HasKey(k => k.IdGenre);
        //     modelBuilder.Entity<Genre>().HasIndex(b => b.IdGenre);
        // }
    }
}