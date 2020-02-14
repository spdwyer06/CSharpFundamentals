using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    //  a repository holds methods
   //   Create (Method), Read (Method), Update (Method), Delete (Method)
    public class StreamingContentRepository
    {
        protected readonly List<StreamingContent> _listOfContent = new List<StreamingContent>();

        //  Create
        public bool AddContentToDirectory(StreamingContent content)
        {
            int directoryLength =_listOfContent.Count();
            _listOfContent.Add(content);
            bool wasAdded = directoryLength + 1 == _listOfContent.Count();
            return wasAdded;
        }

        //  Read
        public List<StreamingContent> GetContents()
        {
            return _listOfContent;
        }

        //  Update
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            //  Find the content
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            //  Update the content
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.StarRating = newContent.StarRating;
                oldContent.Description = newContent.Description;
                oldContent.Language = newContent.Language;
                oldContent.Genre = newContent.Genre;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.TypeOfStreamingQuality = newContent.TypeOfStreamingQuality;
                return true; 
            }
            else
            {
                return false; 
            }
        }

        //  Delete
        public bool DeleteExistingContent(string listTitle)
        {
            StreamingContent foundContent = GetContentByTitle(listTitle);
            bool deletedResult = _listOfContent.Remove(foundContent);
            return deletedResult;
        }
      
        //  Helper Method
        public StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent content in _listOfContent)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content; 
                }
            }
            return null; 
        }
    }
}
