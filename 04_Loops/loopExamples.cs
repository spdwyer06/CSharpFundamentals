using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Loops
{
    [TestClass]
    public class loopExamples
    {
        [TestMethod]
        public void DoWhileLoops()
        {
            // Do While Loop Structure
            //      declared variable = count
            //      do
            //      {
            //          line of code;
            //          variable count increase;
            //      }
            //      while (variable meets whatever argument);

            int iterator = 0;
            do
            {
                Console.WriteLine("Hello");
                iterator++; //the "++" adds 1 to the iterator value
                            //to add 2 to the iterator value you would use "iterator+2;"
            }
            while (iterator < 5);

            do
            {
                Console.WriteLine("My do while condition is false!");
            }
            while (false);
        }

        [TestMethod]
        public void ForLoops()
        {
            //1 Starting point, fires off only once
            //2 Condition that while true keeps the loop running
            //3 What happens after each loop
            //4 Body of the loop, what happens each iteration


            int studentCount = 34;
                    //1             //2       //3
            for (int i = 0; i < studentCount; i++)
            {   //4
                Console.WriteLine(i);
            }

            string[] students = { "Nick", "Craig", "Justin", "Isaiah" };
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Welcome to class class {students[i]}!");
            }
        }

        // holding the alt key while on a line of code and then pressing an arrow key will move that line either up or down
        //"ctrl + x" will erase an entire line from the code
        // "ctrl + kc" will comment out a line of code
        //"ctrl + ku" will uncomment a line of code
        // "ctrl + ew" will wrap the line of code

        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            //1 Loop runs while the condition is true
            //2 Body of the loop

                        //1
            while (total != 10)
            {       //2
                Console.WriteLine(total);
                total++;
            }

            Random rand = new Random();
            int someCount;
            bool keepLooping = true;

            while (keepLooping)
            {
                someCount = rand.Next(0, 20);
                if (someCount == 6 || someCount == 10 || someCount == 13) //more than 2 
                {
                    continue;
                }
                Console.WriteLine(someCount);

                if (someCount == 15)
                {
                    keepLooping = false;
                    //break;   another way of ending the above loop
                }
            }
        }

        [TestMethod]
        public void ForeachLoops()
        {
            //1 Collection that is being worked on
            //2 Name of the current iteration being used
            //3 Current Type in the collection
            //4 The "in" keyword, used to separate the individual and the collection
            //5 Body of the loop

            string[] students = { "Nick", "Craig", "Justin", "Isaiah", "Tom", "Un Yon", "Josh" };
                       //3   //2   //4  //1
            foreach (string person in students)
            {       //5
                Console.WriteLine(person + " is a student.");
            }

            string myName = "Sean Patrick Dwyer";
            foreach (char letter in myName)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }

            //List<List<string>> listOfLists = new List<List<string>>();
            //foreach(List<string> list in listOfLists)
            //{
            //    foreach(string str in list)
            //    {

            //    }
            //}
        }

        [TestMethod]
        public void KeyChallenge()
        {
            //  Your client needs a secure key for their website's customers. You need to write the code that generates a string that has 10 random alphanumeric characters. Your client would like the each code to not include any vowels. He also hates the number 13, so make sure none of your codes include the number 13!

            //  generate string w/ 10 random alphanumeric characters
            //  do NOT include "a, e, i, o, u" or "13"

            string characters = "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz012456789";
            var stringCharacters = new char[10]; //creating a character array of 10
            Random rand = new Random();

            for (int i = 0; i < stringCharacters.Length; i++)
            {
                stringCharacters[i] = characters[rand.Next(characters.Length)];
            }

            String finalString = new String(stringCharacters);
            Console.WriteLine(finalString);
        }

        [TestMethod]
        public void KeyChallenge2()
        {
            //solution demo in class

        //   Type     Name     =  Value
            string customerKey = "";
            string characters = "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz0123456789";
            Random rand = new Random();

            while (customerKey.Length < 10)
            {
                int randomNumber = rand.Next(0, characters.Length);
                char nextCharacter = characters[randomNumber];

                if (customerKey.EndsWith("1") && nextCharacter == '3') //verifying that "13" not a possible combination
                {
                    continue;
                }

                customerKey = customerKey + nextCharacter;   //customerKey += nextCharacter;

               
            }
            Console.WriteLine(customerKey);
        }
    }
}
