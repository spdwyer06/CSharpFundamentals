using _07_RepositoryPattern_Repository;
using _07_RepositoryPattern_Repository.ContentTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_ConsoleUI.UI
{
    public class ProgramUI 
    {
        private readonly StreamingRepository _streamingRepository = new StreamingRepository();  // News up an instance of _streamingRepository to be used by all methods

        private IConsole _console;

        public ProgramUI(IConsole console)
        {
            _console = console; 
        }

        public void Run()
        {
            SeedContentList(); // pulling in already stored content
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                _console.Clear();

                _console.WriteLine("Select an option number:\n" +
                "1. Show all streaming content\n" +
                "2. Display all shows\n" +
                "3. Display all movies\n" +
                "4. Add streaming content\n" +
                "5. Update existing content\n" +
                "6. Remove streaming content\n" +
                "7. Exit program");

                string userInput = _console.ReadLine();
                userInput = userInput.Replace(" ", "");  // will get rid of any blank spaces put in by user
                userInput = userInput.Trim(); // will get rid of any spaces created by using tab

                switch (userInput)
                {
                    case "1":
                        //  show all content
                        ShowAllContent();
                        break;
                    case "2":
                        //  display all shows
                        ShowAllShows();
                        break;
                    case "3":
                        //  display all movies
                        ShowAllMovies();
                        break;
                    case "4":
                        //  add streaming content
                        AddNewStreamingContent();
                        break;
                    case "5":
                        //  update existing content
                        UpdateExistingContent();
                        break;
                    case "6":
                        //  remove streaming content
                        RemoveExistingContent();
                        break;
                    case "7":
                        //  exit program
                        continueToRun = false;
                        break;
                    default: continue; // will re-loop if user inputs something other than given options
                }
            }

        }

        // Access to streaming repo/the Add Method
        // Prompt the user
        // Take in content from the console
        // Actually add the contrent through the Add Method
        private void AddNewStreamingContent()
        {
            _console.Clear();

            StreamingContent content = new StreamingContent();
            _console.WriteLine("Please enter a Title");
            content.Title = _console.ReadLine();         //  Stores the user input as a string

            _console.WriteLine("Add a Description");
            content.Description = _console.ReadLine();

            _console.WriteLine("Add the Genre");
            content.Genre = _console.ReadLine();

            _console.WriteLine("Add a Star Rating");
            content.StarRating = Convert.ToInt32(_console.ReadLine());     // Converts the string input to an integer
            // content.StarRating = int.Parse(_console.ReadLine());    //  Does the same as the above line of code

            _console.WriteLine("Add a Maturity Rating:\n" +
                "1) G  \n" +
                "2) PG \n" +
                "3) PG-13 \n" +
                "4) R \n" +
                "5) NR ");
            
            string maturityString = _console.ReadLine();
            int ratingID = int.Parse(maturityString);
            content.MaturityRating = (MaturityRatingType)ratingID;

            _console.WriteLine("Enter the Language:\n" +
                "1) English \n" +
                "2) Spanish \n" +
                "3) French \n" +
                "4) Japanese \n" +
                "5) Chinese ");
            string language = _console.ReadLine();   // Since this property is in a enum you must convert that to a readable value for the program
            int languageID = int.Parse(language);
            content.Language = (LanguageType)languageID;

            _console.WriteLine("Select a Streaming Quality: \n" +
                "1) SD240p \n" +
                "2) SD480p \n" +
                "3) HD720p \n" +
                "4) HD1080p \n" +
                "5) UHD4K ");
            string userInput = _console.ReadLine();
            switch(userInput) 
            {
                case "1":
                    content.TypeOfStreamingQuality = (StreamingQualityType)int.Parse(userInput);
                    break;
                case "2":
                    content.TypeOfStreamingQuality = (StreamingQualityType)int.Parse(userInput);    // Both ways will work
                    break;
                case "3":
                    content.TypeOfStreamingQuality = StreamingQualityType.Hd720p;   // Both ways will work
                    break;
                case "4":
                    content.TypeOfStreamingQuality = StreamingQualityType.Hd1080p;
                    break;
                case "5":
                    content.TypeOfStreamingQuality = StreamingQualityType.UHD4k;
                    break; 
            }



            _streamingRepository.AddContentToDirectory(content);
            _console.WriteLine("Your content has been added.\n" +
                "Press any key to return to the main menu.");
            _console.ReadKey();
        }
        
        // Update existing content
        // Find existing content
        // Create an updated version
        // Pass the updated content to the repository Update method
        private void UpdateExistingContent()
        {
            _console.Clear();

            _console.WriteLine("Enter the Title of the content you would like to update.");
            string targetTitle = _console.ReadLine();
            StreamingContent existingContent = _streamingRepository.GetContentByTitle(targetTitle);



            if(existingContent is null)
            {
                _console.WriteLine("There is no content with that Title.\n" +
                    "Press any key to continue.");
                _console.ReadKey(); 
            }
            else
            {
                StreamingContent content = new StreamingContent();
                _console.WriteLine($"Current Title: {existingContent.Title}.\n" +
                    $"Please enter a new Title");
                content.Title = _console.ReadLine();         //  Stores the user input as a string

                _console.WriteLine($"Current Descirption: {existingContent.Description}.\n" +
                    $"Add a new Description");
                content.Description = _console.ReadLine();

                _console.WriteLine($"Current Genre: {existingContent.Genre}.\n" +
                    $"Add a new Genre");
                content.Genre = _console.ReadLine();

                _console.WriteLine($"Current Star Rating: {existingContent.StarRating}.\n" +
                    $"Add a new Star Rating");
                content.StarRating = Convert.ToInt32(_console.ReadLine());     // Converts the string input to an integer
                                                                              // content.StarRating = int.Parse(_console.ReadLine());    //  Does the same as the above line of code

                _console.WriteLine($"Current Maturity Rating: {existingContent.MaturityRating}. \n" +
                    $"Add a new Maturity Rating:\n" +
                    "1) G  \n" +
                    "2) PG \n" +
                    "3) PG-13 \n" +
                    "4) R \n" +
                    "5) NR ");

                string maturityString = _console.ReadLine();
                int ratingID = int.Parse(maturityString);
                content.MaturityRating = (MaturityRatingType)ratingID;

                _console.WriteLine($"Current Language: {existingContent.Language}.\n" +
                    $"Enter the new Language:\n" +
                    "1) English \n" +
                    "2) Spanish \n" +
                    "3) French \n" +
                    "4) Japanese \n" +
                    "5) Chinese ");
                string language = _console.ReadLine();   // Since this property is in a enum you must convert that to a readable value for the program
                int languageID = int.Parse(language);
                content.Language = (LanguageType)languageID;

                _console.WriteLine($"Current Streaming Quality: {existingContent.TypeOfStreamingQuality}.\n" +
                    $"Select a new Streaming Quality: \n" +
                    "1) SD240p \n" +
                    "2) SD480p \n" +
                    "3) HD720p \n" +
                    "4) HD1080p \n" +
                    "5) UHD4K ");
                string userInput = _console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        content.TypeOfStreamingQuality = (StreamingQualityType)int.Parse(userInput);
                        break;
                    case "2":
                        content.TypeOfStreamingQuality = (StreamingQualityType)int.Parse(userInput);    // Both ways will work
                        break;
                    case "3":
                        content.TypeOfStreamingQuality = StreamingQualityType.Hd720p;   // Both ways will work
                        break;
                    case "4":
                        content.TypeOfStreamingQuality = StreamingQualityType.Hd1080p;
                        break;
                    case "5":
                        content.TypeOfStreamingQuality = StreamingQualityType.UHD4k;
                        break;
                }

                _streamingRepository.UpdateExistingContent(existingContent.Title, content);
                _console.WriteLine("content has been successfully updated.\n" +
                    "Press any key to continue.");
                _console.ReadKey();
            }

        }

        // Get all streaming content info
        // Prompt user for individual content
        // Get individual content info
        // Remove content from list
        // Save updated list
        private void RemoveExistingContent()
        {
            _console.Clear();

            _console.WriteLine("Enter the Title of the content you would like to delete.");
            string targetTitle = _console.ReadLine();
            _streamingRepository.DeleteExistingContent(targetTitle);
            _console.WriteLine($"{targetTitle} has been successfully deleted\n" +
                $"Press any key to continue.");
            _console.ReadKey();

        }
    

    private void ShowAllContent()
        {
            _console.Clear();

            // get all content
            List<StreamingContent> contents = _streamingRepository.GetContents();
            // go through all content and display its properties
            foreach (StreamingContent content in contents)
            {
                _console.WriteLine($"Title: {content.Title}\n" +
                    $"Genre: {content.Genre}\n" +
                    $"Description: {content.Description}\n" +
                    $"Star Rating: {content.StarRating}\n" +
                    $"Maturity Rating: {content.MaturityRating}\n" +
                    $"Language: {content.Language}\n" +
                    $"Type Of Streaming Quality: {content.TypeOfStreamingQuality}\n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}\n");
            }

            _console.WriteLine("Press any key to continue.");
            _console.ReadKey(); // pressing ANY key will close the window
                               // _console.ReadLine(); // pressing ENTER will close the window

        }

        private void ShowAllShows()
        {
            _console.Clear();

            List<Show> shows = new List<Show>();
            shows = _streamingRepository.GetAllShows();
            foreach (Show content in shows)
            {
                _console.WriteLine($"Title: {content.Title}\n" +
                    $"Genre: {content.Genre}\n" +
                    $"Description: {content.Description}\n" +
                    $"Star Rating: {content.StarRating}\n" +
                    $"Maturity Rating: {content.MaturityRating}\n" +
                    $"Language: {content.Language}\n" +
                    $"Type Of Streaming Quality: {content.TypeOfStreamingQuality}\n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}\n" +
                    $"Average Run Time: {content.AverageRunTime} minutes\n" +
                    $"Episode Count: {content.EpisodeCount}\n" +
                    $"Season Count: {content.SeasonCount}\n");

                foreach (Episode episode in content.Episodes)
                {
                    _console.WriteLine(episode.Title); // no episodes have been declared yet so nothing will be displayed for this instance
                }

            }
            _console.WriteLine("Press any key to continue.");
            _console.ReadKey();
        }

        private void ShowAllMovies()
        {
            _console.Clear();

            List<Movie> movies = new List<Movie>();
            movies = _streamingRepository.GetAllMovies();
            foreach (Movie content in movies)
            {
                _console.WriteLine($"Title: {content.Title}\n" +
                   $"Genre: {content.Genre}\n" +
                   $"Description: {content.Description}\n" +
                   $"Star Rating: {content.StarRating}\n" +
                   $"Maturity Rating: {content.MaturityRating}\n" +
                   $"Language: {content.Language}\n" +
                   $"Type Of Streaming Quality: {content.TypeOfStreamingQuality}\n" +
                   $"Is Family Friendly: {content.IsFamilyFriendly}\n" +
                   $"Run Time: {content.RunTime} minutes\n");
            }
            _console.WriteLine("Press any key to continue.");
            _console.ReadKey();
        }

        //  Helper Method
        private void SeedContentList()
        {
            StreamingContent toyStory = new StreamingContent("Bromance", "Toy Story", 10, StreamingQualityType.Hd720p, "A good childhood movie.", LanguageType.English, MaturityRatingType.G);
            _streamingRepository.AddContentToDirectory(toyStory);

            Movie theMatrix = new Movie("Sci-Fi", "The Matrix", 8, StreamingQualityType.Hd1080p, "Figthing robots that want to put us in tubes", LanguageType.English, MaturityRatingType.R, 90);
            _streamingRepository.AddContentToDirectory(theMatrix);

            Show naruto = new Show("Anime", "Naruto", 9, StreamingQualityType.Hd1080p, "Ninjas", LanguageType.Japanese, MaturityRatingType.PG_13, new List<Episode>());
            _streamingRepository.AddContentToDirectory(naruto);
        }
    }
}

