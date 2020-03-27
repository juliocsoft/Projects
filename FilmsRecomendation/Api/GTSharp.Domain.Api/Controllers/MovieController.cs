using System.Collections.Generic;
using GTSharp.Domain.Entities;
using GTSharp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GTSharp.Domain.Api.Controllers
{
    [ApiController]
    [Route("v1/movies")]
    public class MovieController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<Movie> Get([FromServices]IMovieRepository repository)
        {
            return repository.Get();
        }

        [Route("all")]
        [HttpGet]
        public IEnumerable<Movie> GetAll([FromServices]IMovieRepository repository)
        {
            return repository.GetAll();
        }

        [Route("withoutoverview")]
        [HttpGet]
        public IEnumerable<Movie> GetMoviesWithoutOverview([FromServices]IMovieRepository repository)
        {
            return repository.GetMoviesWithoutOverview();
        }

        [Route("withoutgenre")]
        [HttpGet]
        public IEnumerable<Movie> GetMoviesWithoutGenre([FromServices]IMovieRepository repository)
        {
            return repository.GetMoviesWithoutGenre();
        }

        [Route("{id:int}")]
        [HttpGet]
        public Movie GetById([FromServices]IMovieRepository repository, int id)
        {
            return repository.GetById(id);
        }

    }
}