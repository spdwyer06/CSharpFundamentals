using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges.Feb_10_Challenge
{
    [TestClass]
    public class VehicleTests 
    {
        [TestMethod]
        public void VehicleFunctionsTests()
        {
            Vehicle myCar = new Vehicle("Scion", "tC", "White", VehicleType.Sedan);
            myCar.Drive();


            Vehicle myBike = new Vehicle("Suzuki", "RF900r", "Black", VehicleType.Motorcycle);
            myBike.Start();
            myBike.Drive();
            myBike.TurnOff();


            Vehicle gfCar = new Vehicle("Kia", "Spectra", "Blue", VehicleType.Sedan);
            gfCar.Start();
            gfCar.Drive();
        }





        
    }
}
