using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ///*
            Console.WriteLine($"The Name Game!\n" +
                $"");

            Console.Write("What is your first name?: ");
            string firstName = Console.ReadLine();

            Console.Write("What is your middle name?: ");
            string middleName = Console.ReadLine();

            Console.Write("What is your last name?: ");
            string lastName = Console.ReadLine();

            DisplayResult(ReverseString(firstName), ReverseString(middleName), ReverseString(lastName));

            Console.Read();
            //*/

            //  Replaces: (not finished)
            /*
            Console.WriteLine($"The Name Game!\n" +
                $"");

            Console.Write("What is your first name?: ");
            string firstName = Console.ReadLine();

            Console.Write("What is your middle name?: ");
            string middleName = Console.ReadLine();

            Console.Write("What is your last name?: ");
            string lastName = Console.ReadLine();

            char[] firstNameArray = firstName.ToCharArray();
            Array.Reverse(firstNameArray);

            char[] middleNameArray = middleName.ToCharArray();
            Array.Reverse(middleNameArray);

            char[] lastNameArray = lastName.ToCharArray();
            Array.Reverse(lastNameArray);

            string result = $"{Array.Reverse(firstNameArray)}";
            Console.WriteLine($"Results: \n" +
                $"{result}");

            Console.Read();
            */
            
        }

        private static string ReverseString(string name)
        {
            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            return String.Concat(nameArray);

            /*foreach(char letter in nameArray)
            {
                Console.Write(letter);
            }
            Console.Write(" ");
            */
        }

        private static void DisplayResult(string reversedFirstName, string reversedMiddleName, string reversedLastName) 
        {
            Console.WriteLine("\n" +
               "Results: \n" +
               $"{reversedFirstName} {reversedMiddleName} {reversedLastName}");
           // Console.Write($"{reversedFirstName} {reversedMiddleName} {reversedLastName}");
        }
    }
}
