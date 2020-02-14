using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    /*  program that will allow to easily track their customers. => Customer Class
        a unique customer id number
        last name 
        age
        enrollment date
        number of years using Komodo Insurance.

        store and manipulate our customers on a list. => Customer Repository

        any methods built are unit tested.

        send a message to customers based on their years of subscribing. => Repository Method
            If they’ve been part of a plan for 1-5 years, we send them a thank you note.
            If they have been a customer for more than 5 years, we send them a note that says: “Thank you for being a Gold member.”  
            
        Write unit tests to ensure your methods are working properly and use the repository pattern.
*/
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = $"{FirstName} {LastName}";
                return fullName;
            }
        }

       public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get
            {
                    TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                    double totalAgeInYears = ageSpan.TotalDays / 365.25;
                    double floorAge = Math.Floor(totalAgeInYears);
                    int years = Convert.ToInt32(floorAge);
                    return years;
            }
        }

        public DateTime EnrollmentDate { get; set; }
        public int EnrollmentLength
        {
            get
            {
                /*TimeSpan timeEnrolled = DateTime.Now - EnrollmentDate;
                double totalYears = timeEnrolled.Days / 365.25;
                int years = Convert.ToInt32(Math.Floor(totalYears));
                return years;*/

                /*double totalTime = (DateTime.Now - EnrollmentDate).TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor(totalTime));*/

                return Convert.ToInt32(Math.Floor((DateTime.Now - EnrollmentDate).TotalDays / 365.25)); //  All do the same thing
            }
        }

        public string GoldMember { get; set; }


    }
}
