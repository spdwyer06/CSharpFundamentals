using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _09_InterfacesIntroduction
{
    [TestClass]
    public class IFruitTests
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            // you CANNOT new up an instance of an Interface
            IFruit apple = new Apple(); // You must new up a Type of Interface
            var output = apple.Peel();
            Console.WriteLine(output);
            Console.WriteLine($"The apple is peeled: {apple.Peeled}");
            Assert.IsTrue(apple.Peeled);
        }

        [TestMethod]
        public void InterfacesInCollections()
        {
            var orange = new Orange(); // newing up an instance of an object 
            var fruitSalad = new List<IFruit>
            {
                new Apple(),   // adding to list (1st)
                new Grape(),   // adding to list (2nd)
                orange         // adding to list (3rd)
            };  // Semi-colon goes here

            foreach(var fruit in fruitSalad)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());
                Assert.IsInstanceOfType(fruit, typeof(IFruit)); // Asserting that the object "fruit" is of Type "IFruit"

            }
            
            // fruit.Zest();  // Will NOT work since the "Zest" Property was only declared for the Orange Class, not the IFruit Class
            orange.Zest();
            Assert.IsInstanceOfType(orange, typeof(Orange));

        }
        private string GetFruitName(IFruit fruit)  // Interfaces CAN be used as Types
        {
            return $"This fruit is called: {fruit.Name}.";
        }

        [TestMethod]
        public void InterfacesInMethods()
        {
            var grape = new Grape();
            var output = GetFruitName(grape);
            Console.WriteLine(output);
            Assert.IsTrue(output.Contains("This fruit is called: Grape"));
        }

        [TestMethod]
        public void TypeOfInstance()
        {
            List<IFruit> fruitSalad = new List<IFruit>
            {
                new Orange(true),
                new Orange(),
                new Grape(),
                new Apple(true),
                new Grape()
            };  // Semi-colon goes here

            Console.WriteLine("Is the orange peeled?");
            foreach(var fruit in fruitSalad)
            {
                if(fruit is Orange orange)
                {
                    if(orange.Peeled)
                    {
                        Console.WriteLine("Is a peeled orange");
                    }
                    else
                    {
                        Console.WriteLine("We shall zest this orange.");
                        orange.Zest();
                    }
                }
                else if (fruit.GetType() == typeof(Grape)) 
                {
                    Console.WriteLine("This is a grape.");
                }
                else if (fruit.Peeled)
                {
                    Console.WriteLine("This is a peeled apple.");
                }
                else
                {
                    Console.WriteLine("This is a non-peeled apple.");
                }
            }
        }
    }
}
