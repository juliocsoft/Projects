using System.Collections.Generic;
using GTSharp.Domain.Entities;

namespace GTSharp.Domain.Repositories
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> Get();
        IEnumerable<Movie> GetAll();
        IEnumerable<Movie> GetMoviesWithoutOverview();
        IEnumerable<Movie> GetMoviesWithoutGenre();
        Movie GetById(int id);
    }
}