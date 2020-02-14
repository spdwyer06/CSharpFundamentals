using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            // Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            //  Act
            bool addResult = repository.AddContentToDirectory(content);

            //  Assert
            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            repository.AddContentToDirectory(content);

            List<StreamingContent> contents = repository.GetContents();

            bool directoryHasContent = contents.Contains(content);
            Assert.IsTrue(directoryHasContent);
        }

        private StreamingContentRepository _repository;
        private StreamingContent _content;
        [TestInitialize] // runs before any test method runs
        public void Arrange()
        {
            _repository = new StreamingContentRepository();
            _content = new StreamingContent("Drama", "Rubber", 1, StreamingQualityType.UHD4k, "A car tyre comes to life with the power to make people explode and goes on a murderous rampage through the Californian desert.", LanguageType.French, MaturityRatingType.R);
            _repository.AddContentToDirectory(_content);
        } 

        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            StreamingContent searchResult = _repository.GetContentByTitle("Rubber");
            Assert.AreEqual(_content, searchResult);
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            StreamingContent newContent = new StreamingContent("Drama", "Rubber", 100, StreamingQualityType.Sd240p, "A car tyre comes to life with the power to make people explode and goes on a murderous rampage through the Californian desert.", LanguageType.French, MaturityRatingType.R);
            bool updateResult = _repository.UpdateExistingContent("Rubber", newContent);

            Assert.IsTrue(updateResult);
        }

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            bool removeResult = _repository.DeleteExistingContent("Rubber");
            Assert.IsTrue(removeResult);
        }
    }
}
