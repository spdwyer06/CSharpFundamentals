﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository.ContentTypes
{
    public class Movie: StreamingContent
    {
        public Movie() { }
        public Movie(string genre, string title, int starRating, StreamingQualityType typeOfQuality, string description, LanguageType language, MaturityRatingType maturityRating, double runTime)
          // calling streamingContent Constructor
          : base(genre, title, starRating, typeOfQuality, description, language, maturityRating)
        {
            RunTime = runTime; 
        }

        public double RunTime { get; set; }
    }
}
