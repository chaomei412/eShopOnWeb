using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.core.Domain.Entities;

namespace demo.core.Services
{
    public class MovieQueryService : IMovieService
    {
        public MovieQueryService(string connectionString)
        {

        }

        public IList<Movie> GetMovies()
        {
            throw new NotImplementedException();
        }
    }
}
