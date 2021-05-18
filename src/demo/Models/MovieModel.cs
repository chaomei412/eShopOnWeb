using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo.Models
{
    public class MovieModel
    {
        public MovieModel(int id, string title)
        {
            Id = id;
            Title = title;

        }

        public int Id
        {
            get; private set;
        }

        public string Title
        {
            get; private set;
        }
    }
}
