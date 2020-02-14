using System;
using System.Collections.Generic;
using _07_RepositoryPattern_ConsoleUI.UI;
using _07_RepositoryPattern_Tests.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class ProgramUITests
    {
        [TestMethod]
        public void AddToList_ShouldSeeItemInOutput()
        {
            // Arrange

            List<string> commandList = new List<string> { "4", "Title", "Description", "Genre", "4", "4", "5", "1", "7" }; // order matters
            
            MockConsole console = new MockConsole(commandList);

            ProgramUI ui = new ProgramUI(console);

            // Act
            ui.Run();
            Console.WriteLine(console.Output);

            // Assert

        }

    }
}
