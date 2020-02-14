using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Methods
{
    /* The "[TestMethod]" tag is only used in the unit testing frame, not necessary for the actual code */
    [TestClass]
    public class methodExamples
    {
            //1     2      3
        // public void SayHello(string name)

        //1 Access Modifier (i.e. "public")
        //2 Return/Reference Type (i.e. "void")
        //3 Method Signature (i.e. "SayHello(string name)")
                // SayHello = Method Name
                // string = Argument
                // name = Parameter

        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;  //
            return sum;                // return numOne + numTwo; <----would replace both lines of code
        }

        public int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public double Add(double numberOne, double numberTwo)
        {
            return numberOne + numberTwo;
        }

        private int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            double floorAge = Math.Floor(totalAgeInYears);       // int years = Convert.ToInt32(Math.Floor(totalAgeInYears)); <----would replace both lines of code
            int years = Convert.ToInt32(floorAge);              //
            return years; 
        }


        [TestMethod]
        public void MethodExecution()
        {
            SayHello("George");
            SayHello("Josh");

            int total = Add(23, 86);     // Console.WriteLine(Add(23, 86)); <----would replace both lines of code
            Console.WriteLine(total);   //
            Console.WriteLine(Subtract(4, 1));
            Console.WriteLine(Multiply(2, 3));
            Console.WriteLine(Divide(9, 3));
            Console.WriteLine(Add(1, 1.5));
            DateTime birthdate = new DateTime(1992, 01, 03);
            Console.WriteLine(CalculateAge(birthdate));
        }

    }
}
