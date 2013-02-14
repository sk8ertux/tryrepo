using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace movie.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public DateTime MovieDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}