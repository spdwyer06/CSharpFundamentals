using _07_RepositoryPattern_Repository.ContentTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{       // you still will NOT inherit PRIVATE Properties/Classes through inheritance
       //   you WILL inherit PROTECTED Properties/Classes 
    public class StreamingRepository: StreamingContentRepository
    {
        //  Get all shows => Method
        public List<Show> GetAllShows()
        {
            //  make a new List that holds Shows
            List<Show> shows = new List<Show>();
            //  look at all streaming content and check if it's a Show
            foreach (StreamingContent content in _listOfContent)
            {
                if (content is Show show) //  Pattern Matching
                {
                    //  add each show to a List of Shows
                    //  shows.Add((Show)content);  //  Casting
                    shows.Add(show);
                }
            }
            //  return List of Shows
            return shows; 
        }


        //  Get all movies => Method
        public List<Movie> GetAllMovies()
        {
            List<Movie> movies = new List<Movie>(); 

            foreach (StreamingContent content in _listOfContent)
            {
                if (content is Movie)
                {
                    movies.Add((Movie)content);
                }
            }

            return movies; 
        }

        // "ctrl + rr" will rename ALL References whether or not it is in the same scope you are working in 
        




        //  Get show by title => Method
        //public List<Show> GetShowByTitle(string title)
        
        //  Get movie by title => Method

        //  Update existing show => Method
        //  Update existing movie => Method

        //  Delete existing show => Method
        //  Delete existing movie => Method
    }
}
