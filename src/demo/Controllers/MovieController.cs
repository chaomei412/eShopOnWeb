using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo.core.Services;
using demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly ILogger<MovieController> _logger;
        private readonly IMovieService _movieService;

        public MovieController(ILogger<MovieController> logger, IMovieService movieService)
        {
            _logger = logger;
            this._movieService = movieService;
        }

        [HttpGet]
        public IEnumerable<MovieModel> Get()
        {
            var eList = _movieService.GetMovies();

            var list = new List<MovieModel>();

            foreach(var m in eList)
            {
                list.Add(new MovieModel(m.Id, m.Title));
            }


            return list;
        }
    }
}
