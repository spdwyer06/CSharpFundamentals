using System;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{

    //  Arrange, Act, Assert


    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString() // "ctrl + ." will add a reference
        {
            StreamingContent content = new StreamingContent();

            content.Title = "The Matrix";

            string expected = "The Matrix";
            string actual = content.Title;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetGenre_ShouldSetCorrectString()
        {
            StreamingContent category = new StreamingContent();

            category.Genre = "Anime";

            string expected = "Anime";
            string actual = category.Genre;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetStarRating_ShouldSetCorrectInt()
        {
            StreamingContent stars = new StreamingContent();

            stars.StarRating = 5;

            int expected = 5;
            int actual = stars.StarRating;

            Assert.AreEqual(expected, actual);
        }

        /*[TestMethod]
        public void SetMaturityRating_ShouldGetCorrectIsFamilyFriendly()
        {
            StreamingContent content = new StreamingContent("Content Title", "Title", 4, StreamingQualityType.Hd1080p, "description", LanguageType.English, MaturityRatingType.R);

            bool actual = content.IsFamilyFriendly;
            bool expected = false;

            Assert.AreEqual(expected, actual);
        }*/

        [DataTestMethod]  //    this way will test different values
        [DataRow(MaturityRatingType.G, true)]
        [DataRow(MaturityRatingType.NR, true)]
        [DataRow(MaturityRatingType.PG_13, true)]
        [DataRow(MaturityRatingType.PG, true)]
        public void SetMaturityRating_ShouldGetCorrectIsFamilyFriendly(MaturityRatingType rating, bool isFriendly)
        {
            StreamingContent content = new StreamingContent("Content Title", "Title", 4, StreamingQualityType.Hd1080p, "description", LanguageType.English, rating);

            bool actual = content.IsFamilyFriendly;
            bool expected = isFriendly;

            Assert.AreEqual(expected, actual);
        }
    }
}
