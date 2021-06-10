using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Models
{
    public class Movie
    {
        public Guid Id {get; set;}

        public string Genre { get; set; }

        public string Author { get; set; }


        public string ReleaseDate { get; set; }

    }
}
