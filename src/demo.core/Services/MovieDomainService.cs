using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.core.Domain.Entities;
using demo.core.Domain.Repositories;

namespace demo.core.Services
{
    public class MovieDomainService : IMovieService
    {
        private readonly IMovieRepository _movieRepositoy;

        public MovieDomainService(IMovieRepository movieRepositoy)
        {
            this._movieRepositoy = movieRepositoy;
        }

        public IList<Movie> GetMovies()
        {
            return _movieRepositoy.GetMovies();
        }
    }
}