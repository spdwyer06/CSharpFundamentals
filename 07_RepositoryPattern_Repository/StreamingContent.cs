using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public enum StreamingQualityType { Sd240p = 1, Sd480p, Hd720p, Hd1080p, UHD4k}
    public enum LanguageType { English = 1, Spanish, French, Japanese, Chinese}
    public enum MaturityRatingType { G = 1, PG, PG_13, R, NR } // "G = 1" sets the index of that item to 1

    // Plain Old C# Object -- POCO
    public class StreamingContent 
    {
        public string Genre { get; set; }
        public string Title { get; set; }
        public int StarRating { get; set; }
        public StreamingQualityType TypeOfStreamingQuality { get; set; }
        public string Description { get; set; }
        public LanguageType Language { get; set; }
        public bool IsFamilyFriendly
        {
            get
            {
                switch (MaturityRating)    // "sw + tab + tab" will scaffold out a switch case
                {
                    case MaturityRatingType.G:
                    case MaturityRatingType.PG:
                    case MaturityRatingType.PG_13:
                        return true;
                    case MaturityRatingType.R:
                    case MaturityRatingType.NR:
                    default: 
                        return false;
                }
            }
        }
        public MaturityRatingType MaturityRating { get; set; }

        public StreamingContent() { }
        public StreamingContent(string genre, string title, int starRating, StreamingQualityType typeOfQuality, string description, LanguageType language, MaturityRatingType maturityRating)
        {
            Genre = genre;
            Title = title;
            StarRating = starRating;
            TypeOfStreamingQuality = typeOfQuality;
            Description = description;
            Language = language;
            MaturityRating = maturityRating;

        }
    }
}
