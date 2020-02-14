using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypeExamples
    {
        [TestMethod]
        public void Strings()
        {
            string firstName = "Sean";
            string lastName = "Dwyer";

            string concatenatedFullName = "Hello" + firstName + " " + lastName;
            Console.WriteLine(concatenatedFullName);

            //0 is always the first number in any index
            string compositeFullName = string.Format("Hello {0} {1}", firstName, lastName);
            Console.WriteLine(compositeFullName);

            //take note of the "$" symbol at the beginning
            string interpolatedFullName = $"Hello {firstName} {lastName}";
            Console.WriteLine(interpolatedFullName);

            DateTime curTime = DateTime.Now;
            Console.WriteLine(curTime);
            Console.ReadKey();
        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World!";
            string[] stringArray = { "Hello", "World!", "Why", "is it", "always", stringExample, "?"};
            //if you want to call just a single item from an array
            Console.WriteLine(stringArray[2]);
            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);
            //to change the value of an indexed item in the array
            stringArray[0] = "Hey there";
            Console.WriteLine(stringArray[0]);

            //making a new instance of a list
            List<string> listOfStrings = new List<string>();
            List<int> listOfInts = new List<int>();
            //can only add 1 item at a time using ".Add"
            listOfStrings.Add("First string in our list.");
            listOfInts.Add(9);
            //using ".AddRange" you can add multiple entries at once
            listOfStrings.AddRange(stringArray);

            //don't forget about the breakpoint tool

            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first!");
            firstInFirstOut.Enqueue("I'm next in line!");
            string firstItem = firstInFirstOut.Dequeue();

            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            keyAndValue.Add(22, "string");
            //the preffered way of naming this variable would be "valueTwentyTwo"
            string value22 = keyAndValue[22];
            Console.WriteLine(value22);

            SortedList<int, string> sortedKeyAndValuePair = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();
        }

        [TestMethod]
        public void Classes()
        {
            Random rng = new Random();
            int randomNumber = rng.Next();
            Console.WriteLine(randomNumber);
        }
    }
}
