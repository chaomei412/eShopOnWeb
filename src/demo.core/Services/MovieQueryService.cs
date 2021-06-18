using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using demo.core.Domain.Entities;

namespace demo.core.Services
{
    public class MovieQueryService : IMovieService
    {
        private string _connectionstring = "Data Source=Movie;Mode=Memory;Cache=Shared";
        public MovieQueryService(string connectionString)
        {
            if(!string.IsNullOrEmpty(connectionString))
                _connectionstring = connectionString;
        }

        public IList<Movie> GetMovies()
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                return connection.Query<Movie>("SELECT * FROM Movies").ToList();
            }
        }
    }
}
