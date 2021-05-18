using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.core.Domain.Entities;
using demo.core.Domain.Repositories;
using demo.core.EF;

namespace demo.core.Repositories
{
    public class MovieEfRepository : IMovieRepository
    {
        private readonly MovieDataContext _dbContext;

        public MovieEfRepository(MovieDataContext dbContext)
        {
            this._dbContext = dbContext;

            _dbContext.Movies.AddRange(
              new List<Movie>()
                        {
                            new Movie(1){
                                Title = "X-Man"
                            },
                            new Movie(2){
                                Title = "Mulan"
                            },
                            new Movie(3){
                                Title = "Avenger"
                            }
                        });

            _dbContext.SaveChanges();
        }

        public IList<Movie> GetMovies()
        {
            return _dbContext.Movies.ToList();
        }
    }
}
