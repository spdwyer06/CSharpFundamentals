using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesGetSetDemo
{
    class Movie    
    {
        public string title; 
        public string director;
        private string _rating;

        public Movie(string Title, string Director, string Rating)
        {
            title = Title;
            director = Director;
            _rating = Rating;
        }

        public string Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    _rating = value;
                }
                else
                {
                    _rating = "NR";
                }
            }
        }
    }
}
