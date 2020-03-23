using System;
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

        public IEnumerable<Movie> GetAll()
        {
            return _context.Movies
               .AsNoTracking()
               .Where(MovieQueries.GetAll())
               .OrderBy(x => x.OriginalTitle);
        }

        // public IEnumerable<TodoItem> GetAll(string user)
        // {
        //     return _context.Todos
        //        .AsNoTracking()
        //        .Where(TodoQueries.GetAll(user))
        //        .OrderBy(x => x.Date);
        // }

        // public IEnumerable<TodoItem> GetAllDone(string user)
        // {
        //     return _context.Todos
        //         .AsNoTracking()
        //         .Where(TodoQueries.GetAllDone(user))
        //         .OrderBy(x => x.Date);
        // }

        // public TodoItem GetById(Guid id, string user)
        // {
        //     return _context.Todos
        //         .FirstOrDefault(x => x.Id == id && x.User == user);
        // }

    }
}