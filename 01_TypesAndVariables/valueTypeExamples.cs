using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class valueTypeExamples
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;
            isDeclared = true;
            bool isDeclarationAndInitialized = false;
            // how to make a note 
         }

        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char symbol = '&';
            char number = '9';
            char space = ' ';
            char specialCharacter = '\n'; //new line character
        }

        // Type "testm" then hit tab twice to get the following code snippit
        [TestMethod]
        public void wholeNumbers()
        {
            byte byteExample = 255; //2^8th
            sbyte sByteExample = -128; //sbyte ranges from -128 to +127
            short shortExample = 32767; //2^16th
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 intMax = 2147483647; //default value for whole numbers
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;

            int a = 15;
            int b = 22;
            int c = 37;
            byte age = 254;
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.045231f; //notice the float tag at the end
            double doubleExample = 1.789053278907036d; //notice the double tag at the end, not necessary but good practice to use //default value for decimals
            decimal decimalExample = 1.2578907289045789789789789787897m;
            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);
        }

        enum pastryType {Cake, Danish, Doughnut, Scone, Cupcake, Croissant}

        [TestMethod]
        public void Enums()
        {
            pastryType myPastry = pastryType.Doughnut;
            pastryType anotherPastry = pastryType.Croissant;
            Console.WriteLine(myPastry);
            Console.WriteLine(anotherPastry);
        }

        [TestMethod]
        public void Structs()
        {
            Int32 age = 42;
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(2020, 01, 03);
            Console.WriteLine(today);
            Console.WriteLine(birthday.ToShortDateString());
        }


        [TestMethod]
        public void Challenges()
        {
            int myAge = 28;
            char favNmber = '9';
            float piNumber = 3.14159265359f;
            double randomDecimal = 1.84756;
            sbyte negNumber = -13;
            Console.WriteLine(myAge);
            Console.WriteLine(favNmber);
            Console.WriteLine(piNumber);
            Console.WriteLine(randomDecimal);
            Console.WriteLine(negNumber);
        }

    }
}
