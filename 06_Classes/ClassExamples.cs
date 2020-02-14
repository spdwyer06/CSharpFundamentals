using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes
{
    public enum VehicleType { Car, Truck, Airplane, Train, Boat, Bike, Spaceship }

    public class Vehicle
    {
        public Vehicle() // first constructor
        {
            BodyColor = "Magenta";
        }

        public Vehicle(string make, string model, double milege, string bodyColor, VehicleType type)    // "ctor + tab + tab" will scaffold out a constructor
        {
            Make = make;
            Model = model;
            Mileage = milege;
            BodyColor = bodyColor;
            TypeOfVehicle = type;
        }

        public string BodyColor { get; set; }  // Properties will almost always be public and have Pascal Casing (the first letter of each word capitalized)
        public string Make { get; set; }    // "{ get; set; }" is what turns a field into a property
        public string Model { get; set; }   // fields are typically for private use
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }  // referencing the enum created at the top
    }

    public class Person
    {
        public string FirstName { get; set; } // "prop + tab + tab" will scaffold out a property


        private string _lastName;             // "propfull tab tab"      the underscore before the variable name dictates that it is a private class
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }                                 //

        public string FullName
        {
            get
            {
                string fullName = $"{FirstName} {LastName}";

                //if(FirstName==null && LastName==null)
                if (string.IsNullOrWhiteSpace(fullName))
                {
                    return "Unnamed";
                }
                else
                {
                    return fullName;
                }
            }
        }

        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                if (DateOfBirth == new DateTime())
                {
                    return -404;
                }
                {
                    TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                    double totalAgeInYears = ageSpan.TotalDays / 365.25;
                    double floorAge = Math.Floor(totalAgeInYears);
                    int years = Convert.ToInt32(floorAge);
                    return years;
                }
            }
        }
    }


    // Create a Room class that has three properties: one each for the length, width, and height.
    // Create a method that calculates total square footage.
    // Bonus: Create a method that calculates total lateral surface area.
    // Only allow the properties to be set from inside the class itself.



     public class Room
     {

        public Room(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
     } 
}
