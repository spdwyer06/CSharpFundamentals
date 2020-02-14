using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoviesGetSetDemo
{
    public class Movie
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
