using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository.ContentTypes
{
    public class Show : StreamingContent
    {   // "ctrl + kd" will align items

        public Show () { }

        public Show(string genre, string title, int starRating, StreamingQualityType typeOfQuality, string description, LanguageType language, MaturityRatingType maturityRating, List<Episode> episodes)
            // calling streamingContent Constructor
            : base(genre, title, starRating, typeOfQuality, description, language, maturityRating)
        {
            Episodes = episodes;
        }


        public List<Episode> Episodes { get; set; } = new List<Episode>();

        // look into Hashsets
        // check each episode and add it's season number to a collection
        // look for all uniques season numbers (Count from Hashset)
        public int SeasonCount
        {
            get
            {         //type    //name
                HashSet<int> seasonNumbers = new HashSet<int>();
                foreach(Episode episode in Episodes)
                {
                    seasonNumbers.Add(episode.SeasonNumber);
                }
                return seasonNumbers.Count;
            }
        }

        //  return the Count from the Episodes property
        public int EpisodeCount => Episodes.Count;  // the below expressions are the same 
       /*  Block Body
        *{
            get
            {
                return Episodes.Count; 
            }
        } */

        /*  Expression Body
         * {
         *  get => Episodes.Count;
         * }
        */


        public double AverageRunTime
        {
            get
            {
                // declare a total runtime starting at 0
                double totalRunTime = 0;
                // add each episode's runtime to my total
                foreach(Episode individualEpisode in Episodes)
                {
                    totalRunTime += individualEpisode.RunTime;
                }
                // divide total runtime by total episode count
                double averageRuntime = totalRunTime / EpisodeCount;
                // return calculated average
                return averageRuntime;
            }
        }
    }

    public class Episode
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double RunTime { get; set; }
        public int SeasonNumber { get; set; }
        public int EpisodeNumber { get; set; }
    }
}
