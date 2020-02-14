using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Classes
{
    [TestClass]
    public class classTests
    {
        [TestMethod]
        public void VehiclePropertyTests()
        {
            Vehicle airplane = new Vehicle(); // "()" at the end of "Vehicle();" is called the constructor (default settings)
            airplane.BodyColor = "Hot Pink"; // creating and setting a property 
            airplane.Make = "Boeing";
            airplane.Model = "757";
            airplane.Mileage =  0.1;
            airplane.TypeOfVehicle = VehicleType.Airplane;

            Console.WriteLine(airplane.Make + " " + airplane.Model);  // "c + w + tab + tab" will scaffold out Console.WriteLine
            Console.WriteLine("{0} {1}", airplane.Make, airplane.Model);

            Vehicle myCar = new Vehicle();
            myCar.BodyColor = "White";
            myCar.Make = "Scion";
            myCar.Model = "tc";
            myCar.Mileage = 103000.58;
            myCar.TypeOfVehicle = VehicleType.Car;

            Vehicle anotherCar = new Vehicle("Honda", "Civic", 15000.99, "Black", VehicleType.Car);
            Console.WriteLine($"{anotherCar.Make} {anotherCar.Model}");
        }

        [TestMethod]
        public void PersonTests()
        {
            Person firstPerson = new Person();
            firstPerson.FirstName = "Sean";
            firstPerson.LastName = "Dwyer";
            firstPerson.DateOfBirth = new DateTime(1992, 01, 03);

            Console.WriteLine(firstPerson.FirstName);
            Console.WriteLine(firstPerson.FullName);
            Console.WriteLine($"First person is {firstPerson.Age} years old.");

            Person blankPerson = new Person();
            blankPerson.FirstName = "";
            blankPerson.LastName = "";

            Console.WriteLine("Blank name: " + blankPerson.FullName);
            Console.WriteLine($"Blank person is {blankPerson.Age} years old.");
        }

        [TestMethod] //Must be in a test method or test class to show up in Test Explorer
        public void HouseTest()
        {
            Room newRoom = new Room(2, 2, 2);
            double squareFootage = (newRoom.Height) * (newRoom.Length) * (newRoom.Width);
            Console.WriteLine($"The room square footage is: {squareFootage} feet.");
        }
    }
}
