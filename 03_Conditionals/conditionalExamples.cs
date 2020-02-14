using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Conditionals
{
    [TestClass]
    public class conditionalExamples
    {
        [TestMethod]
        public void IfStatement()
        {
            bool userIsHungry = true;
            if (userIsHungry)
            {
                Console.WriteLine("Eat something!");
            }

            int hoursSpentStudying = 1;
            if (hoursSpentStudying < 16)
            {
                Console.WriteLine("Are you even trying?");
            }
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool choresAreDone = false; 
            if (choresAreDone)
            {
                Console.WriteLine("Have fun at the movies.");
            }
            else
            {
                Console.WriteLine("You must stay home and finish your chores!");
            }
        }

        [TestMethod]
        public void SwitchCases()
        {
            int input = 5;
            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello!");
                    break;      //"break" needs to be used after every case in a switch 
                case 2:
                case 3:     //both cases will have the same output
                    Console.WriteLine("What are you doing?");
                    break;
                default:
                    Console.WriteLine("This is default");
                    break;
            }
        }
            [TestMethod]
        public void Ternaries()
        {
            int age = 42;
            bool isAdult = (age > 17) ? true : false;       //the true value will always be on the left, and the false value will always be on the right
            Console.WriteLine($"Age is over 17: {isAdult}");

            int numOne = 10;
            int numTwo = (numOne == 10) ? 30 : 20;
            Console.WriteLine(numTwo);

            bool isTuesday = DateTime.Now.DayOfWeek.ToString() == "Tuesday";
            Console.WriteLine("Today is " + (isTuesday ? "Tuesday." : "not Tuesday."));
        }
    }
}
