using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.core.Data;
using demo.core.Domain.Entities;

namespace demo.core.Domain.Repositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        IList<Movie> GetMovies();
    }
}
