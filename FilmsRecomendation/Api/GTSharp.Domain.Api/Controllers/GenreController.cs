using System.Collections.Generic;
using GTSharp.Domain.Entities;
using GTSharp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GTSharp.Domain.Api.Controllers
{
    [ApiController]
    [Route("v1/genres")]
    public class GenreController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<Genre> GetAll([FromServices]IGenreRepository repository)
        {
            return repository.GetAll();
        }
    }
}