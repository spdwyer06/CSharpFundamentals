using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes
{
    public class Address
    {
        public string HouseNumber { get; set; }
        public string StreetName { get; set; }
        public string ApartmentNumber { get; set; }
        public string City { get; set; }    
        public string State { get; set; }
        public string ZipCode { get; set; } // some zipcodes may start with a "0" & if defined as an int then the beginning numbers will be dropped 

        public override string ToString()
        {
            return $"{HouseNumber} {StreetName} {ApartmentNumber}\n{City}, {State}\n{ZipCode}";  // "\n" is for a new line
        }
    }
}
