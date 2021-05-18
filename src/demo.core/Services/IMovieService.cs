using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.core.Domain.Entities;

namespace demo.core.Services
{
    public interface IMovieService
    {
        IList<Movie> GetMovies();
    }

    public class MockMovieService : IMovieService
    {
        public IList<Movie> GetMovies()
        {
            return new Movie[]
            {
                new Movie(1){
                    Title = "X-Man"
                },
                new Movie(2)
                {
                    Title = "Mulan"
                }
            };
        }
    }
}
