using System;
using System.Linq.Expressions;
using GTSharp.Domain.Entities;

namespace GTSharp.Domain.Queries
{
    public static class MovieQueries
    {
        public static Expression<Func<Movie, bool>> GetAll()
        {
            return o => o.IdMovie == o.IdMovie;
        }
    }
}