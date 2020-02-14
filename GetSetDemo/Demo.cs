using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetSetDemo
{
    public class Demo
    {
        public class Player
        {
            private int _health = 100; // 
            public int Health
            {
                get
                {
                    return _health;
                }
                set
                {
                    if (value <= 0)   // if health is less than 0 set health to 0
                    {
                        _health = 0;
                    }
                    else if (value >= 100) // if health is greater than 100 set to 100
                    {
                        _health = 100;
                    }
                    else // if health is between 0-100 set as value
                    {
                        _health = value;
                    }
                }
            }
        }

        public static void PlayerHealth(string[] args)
        {
            Player sean = new Player();
            Console.WriteLine($"Player health is {sean.Health}.");

            sean.Health -= 200; // testing lower limit of health
            Console.WriteLine($"Player health is {sean.Health}.");

            sean.Health += 400; // testing upper limit of health
            Console.WriteLine($"Player health is {sean.Health}.");

            sean.Health = 50; // testing normal value of health
            Console.WriteLine($"Player health is {sean.Health}.");

            Console.ReadKey();
        }
    }
}
