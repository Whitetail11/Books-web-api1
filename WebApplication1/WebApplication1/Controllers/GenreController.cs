using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreRepository _genreRepository;
        public GenreController(IGenreRepository _genreRepository)
        {
            this._genreRepository = _genreRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var res = _genreRepository.GetGenres();
            return Ok(res);
        }
    }
}
