using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges.Feb_10_Challenge
{
    class Sedan : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }   
        public bool IsRunning { get; set; }

        public void Start() 
        {
            if (!IsRunning) // IsRunning == false
            {
                IsRunning = true;
                Console.WriteLine("The vehicle is on.");
            }
            else
            {
                Console.WriteLine("The vehicle is already on.");
            }
        }

        public void TurnOff() 
        {
            if (IsRunning)
            {
                IsRunning = false;
                Console.WriteLine("The vehicle is off.");
            }
            else
            {
                Console.WriteLine("The vehicle is already off.");
            }
        }

        public void ToggleIsRunning() 
        {
            if (!IsRunning)
            {
                IsRunning = true;
                Console.WriteLine("The vehicle is on.");
            }
            else
            {
                IsRunning = false;
                Console.WriteLine("The vehicle is off.");
            }
        }

        public void Drive()
        {
            if (IsRunning)
            {
                Console.WriteLine("The vehicle starts driving.");
            }
            else
            {
                Console.WriteLine("The vehicle is off and needs to be started to drive.");
            }
        }

    }
}
