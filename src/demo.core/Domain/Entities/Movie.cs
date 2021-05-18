using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.core.Domain.Entities
{
    public class Movie : BaseEntity, IAggregateRoot
    {
        private Movie()
        {

        }

        public Movie(int movieId)
        {
            base.Id = movieId;
        }

        public string Title
        {
            get; set;
        }
    }
}
