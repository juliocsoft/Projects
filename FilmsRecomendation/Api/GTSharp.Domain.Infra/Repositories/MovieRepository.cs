using System.Collections.Generic;
using GTSharp.Domain.Entities;
using GTSharp.Domain.Repositories;
using GTSharp.Domain.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using GTSharp.Domain.Queries;

namespace GTSharp.Domain.Infra.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DataContext _context;

        public MovieRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Movie> Get()
        {
            return _context.Movie.AsNoTracking();
        }

        public IEnumerable<Movie> GetAll()
        {
            return _context.Movie
               .Include(o => o.Genres)
               .Include(o => o.Overviews)
               .AsNoTracking();
        }

        public IEnumerable<Movie> GetMoviesWithoutOverview()
        {
            return _context.Movie
               .Include(o => o.Genres)
               .AsNoTracking();
        }

        public IEnumerable<Movie> GetMoviesWithoutGenre()
        {
            return _context.Movie
               .Include(o => o.Overviews)
               .AsNoTracking();
        }

        public Movie GetById(int id)
        {
            return _context.Movie
               .Include(o => o.Genres)
               .Include(o => o.Overviews)
               .FirstOrDefault(MovieQueries.ExpById(id));
        }
    }
}