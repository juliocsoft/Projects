using System.Collections.Generic;
using GTSharp.Domain.Entities;

namespace GTSharp.Domain.Repositories
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetAll();
    }
}