using GTSharp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GTSharp.Domain.Infra.Contexts
{
    public class DataContext : DbContext
    {

        public DbSet<TodoItem> Todos { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().ToTable("Todo");
            modelBuilder.Entity<TodoItem>().Property(x => x.Id);
            modelBuilder.Entity<TodoItem>().Property(x => x.User).HasColumnType("varchar(120)");
            modelBuilder.Entity<TodoItem>().Property(x => x.Title).HasColumnType("varchar(160)");
            modelBuilder.Entity<TodoItem>().Property(x => x.Done).HasColumnType("bit");
            modelBuilder.Entity<TodoItem>().Property(x => x.Date);
            modelBuilder.Entity<TodoItem>().HasIndex(b => b.User);

            modelBuilder.Entity<Movie>().ToTable("Movie");
            modelBuilder.Entity<Movie>().Property(x => x.Id);
            modelBuilder.Entity<Movie>().Property(x => x.IdMovie);
            modelBuilder.Entity<Movie>().Property(x => x.Budget);
            modelBuilder.Entity<Movie>().Property(x => x.OriginalTitle).HasColumnType("varchar(300)");
            modelBuilder.Entity<Movie>().Property(x => x.Overview);
            modelBuilder.Entity<Movie>().Property(x => x.Popularity);
            modelBuilder.Entity<Movie>().Property(x => x.PosterPath).HasColumnType("varchar(200)");
            modelBuilder.Entity<Movie>().Property(x => x.ReleaseDate);
            modelBuilder.Entity<Movie>().Property(x => x.VoteAverage);
            modelBuilder.Entity<Movie>().Property(x => x.VoteCount);
            // modelBuilder.Entity<Movie>().Property(x => x.Genres);
            modelBuilder.Entity<Movie>().HasIndex(b => b.OriginalTitle);
        
            modelBuilder.Entity<Genre>().ToTable("Genre");
            modelBuilder.Entity<Genre>().Property(x => x.Id);
            modelBuilder.Entity<Genre>().Property(x => x.IdGenre);
            modelBuilder.Entity<Genre>().Property(x => x.Name).HasColumnType("varchar(200)");
            modelBuilder.Entity<Genre>().HasIndex(b => b.IdGenre);

        }
    }
}