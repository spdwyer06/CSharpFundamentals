using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    /* Create a Calculator class that has the ability to complete all of the following processes:
        Add
        Subtract
        Multiply
        Divide
    
       Write Unit Tests for all of your calculator's functionalities.
 
    Bonus Challenges:
    Allow use of whole numbers and numbers with decimals
    Have the ability to return fractions instead of percentages
    Allow the calculator to take in as many numbers as the user provides */


    // a class creates an object
    public class Calculator
    {                     
        //  making a method static allows you to not have to new up an instance of the class/object 
        public static double Add (double numOne, double numTwo) => numOne + numTwo;

        /* public double Add (double numOne, double numTwo)
         * {
         *      return numOne + numTwo
         * } */

        public double Subtract (double numOne, double numTwo)
        {
            return numOne - numTwo;
        }

        public double Multiply (double numOne, double numTwo)
        {
            return numOne * numTwo;
        }

        public double Divide (double numOne, double numTwo)
        {
            return numOne / numTwo;
        }
    }
}
