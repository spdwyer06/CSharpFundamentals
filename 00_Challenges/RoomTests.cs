using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_Challenges
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        public void CaluculateSquareFootage()
        {
            Room myRoom = new Room();
            myRoom.Length = 10;
            myRoom.Width = 10;

            double squareFootage = myRoom.CalculateSquareFootage();

            Console.WriteLine($"Room square footage is: {squareFootage} feet.");

            Assert.AreEqual(100d, squareFootage);
        }

        [TestMethod]
        public void CheckSquareFootageFraction()
        {
            Room newRoom = new Room
            {
                Length = 10,
                Width = 10,
            };

            int denominator = 2;


            double actual = newRoom.CalculateSquareFootage(denominator);
            double expected = (newRoom.Length) * (newRoom.Width) / denominator;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CheckLateralSurfaceArea() 
        {
            Room anotherRoom = new Room
            {
                Length = 10,
                Width = 10,
                Height = 2,
            };

            double laterSurfaceArea = anotherRoom.CalculateLateralSurfaceArea();
            Console.WriteLine($"Room lateral surface area is: {laterSurfaceArea} feet.");
        }
    }
}
