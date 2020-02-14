using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerHealthGetSetDemo
{
    class PlayerHealthTest
    {

        public static void Main(string[] args) // Console program must have a method labeled "Main" to be able to run
        {
            Player sean = new Player();
            Console.WriteLine($"Player 1 health is: {sean.Health}");
            sean.Mana += 200;
            Console.WriteLine($"Player 1 mana is: {sean.Mana}");

            sean.Health -= 200; // testing lower limit of health
            Console.WriteLine($"Player 1 health is: {sean.Health}");
            sean.Mana += 200;
            Console.WriteLine($"Player 1 mana is: {sean.Mana}");

            sean.Health += 400; // testing upper limit of health
            Console.WriteLine($"Player 1 health is: {sean.Health}");

            sean.Health = 50; // testing normal value of health
            Console.WriteLine($"Player 1 health is: {sean.Health}");

            Player maria = new Player();
            Console.WriteLine($"Player 2 health is: {maria.Health}");
            Console.WriteLine($"Player 2 mana is: {maria.Mana}");
            maria.Mana += 50;
            Console.WriteLine($"Player 2 mana is: {maria.Mana}");

            sean.Mana += 8601;
            Console.WriteLine($"Player 1 mana is: {sean.Mana}");
            Console.WriteLine($"Player 2 mana is: {maria.Mana}");




            Console.ReadKey();
        }
    }
}
