using System;
using System.Linq.Expressions;
using GTSharp.Domain.Entities;

namespace GTSharp.Domain.Queries
{
    public static class GenreQueries
    {
        public static Expression<Func<Genre, bool>> GetAll(int idGenre)
        {
            return o => o.IdGenre == idGenre;
        }
    }
}