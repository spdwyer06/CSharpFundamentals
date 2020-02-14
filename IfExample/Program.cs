
using System;

namespace IfExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            // This way can only evaluate 1 condition

            Console.WriteLine("Sean's Big Giveaway!");
            Console.Write("Choose a door\n" +
                "1, 2, or 3: ");
            string userInput = Console.ReadLine();

                //1             //2         //3  //4 //5   //6
            string prize = (userInput == "3") ? "car" : "not shit";
            Console.WriteLine($"You won a new {prize}!");
            Console.Write("Press any key to exit.");
            Console.ReadKey();

            //1 declared variabled being assigned
            //2 condition being evaluated
            //3 "?" true/false operator
            //4 value if the condition is TRUE
            //5 ":" separates the true/false values
            //6 value if the condition is FALSE
        }
    }
}
