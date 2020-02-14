using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges.Feb_10_Challenge
{
    interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        string Color { get; set; }
        bool IsRunning { get; set; }

        void Start();
        void TurnOff();
        void Drive(); 
    }
}
