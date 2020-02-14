using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges.Feb_10_Challenge
{
    /*
     * create methods that use all of their different types of vehicles 
     * make an interface that can be implemented on all of their classes
     * vehicle types (sedans, SUV, motorcycle, etc) sharing similar attributes and actions 
     * All vehicles need to be able to:
     * start 
     * turn off 
     * drive 
     * have a make, model, and color
     * 
       make the interface and a few example classes
       Write a few tests as well 
     * */
    public enum VehicleType { Sedan, SUV, Truck, Motorcycle}
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string BodyColor { get; set; }
        public VehicleType TypeOfVehicle { get; set; }
        public bool IsEngineOn { get; set; }

        public Vehicle () { }
        public Vehicle(string make, string model, string bodyColor, VehicleType typeOfVehicle)
        {
            Make = make;
            Model = model;
            BodyColor = bodyColor;
            TypeOfVehicle = typeOfVehicle;
        }

        public string Start() 
        {
            IsEngineOn = true;
            return "Vehicle is running.";
        }
        public string TurnOff()
        {
            IsEngineOn = false;
            return "Vehicle is off.";
        }
        public string Drive() 
        {
            if(IsEngineOn==true)
            {
                return "Where would you like to go?";
            }
            else
            {
                return "Start the vehicle first.";
            }
        }

    }
}
