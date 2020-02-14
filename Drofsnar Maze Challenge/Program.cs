using System;
using System.Collections.Generic;

namespace Drofsnar_Maze_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            Drofsnar drofsnar = new Drofsnar(); 

            Dictionary<string, int> scoringItem = new Dictionary<string, int>();
            scoringItem.Add("Bird", 10);
            scoringItem.Add("Crested Ibis", 100);
            scoringItem.Add("Great Kiskudee", 300);
            scoringItem.Add("Red Crossbill", 500);
            scoringItem.Add("Red-necked Phalarope", 700);
            scoringItem.Add("Evening Grosbeak", 1000);
            scoringItem.Add("Greater Prairie Chicken", 2000);
            scoringItem.Add("Iceland Gull", 3000);
            scoringItem.Add("Orange-bellied Parrot", 5000);
            scoringItem.Add("Vulnerable Bird Hunter 1", 200);
            scoringItem.Add("Vulnerable Bird Hunter 2", 400);
            scoringItem.Add("Vulnerable Bird Hunter 3", 800);
            scoringItem.Add("Vulnerable Bird Hunter 4", 1600);
            scoringItem.Add("Invincible Bird Hunter", -1);


            /*
             int itemValue = scoringItem["Bird"];
             Console.WriteLine($"{itemValue} pts.");

             Console.WriteLine($"{scoringItem["Crested Ilbis"]} pts.");

             Console.ReadLine(); 
             */

            string[] gameSequence = { "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Invincible Bird Hunter", "Evening Grosbeak", "Greater Prairie Chicken", "Vulnerable Bird Hunter 1", "Vulnerable Bird Hunter 2", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Iceland Gull", "Crested Ibis", "Great Kiskudee", "Invincible Bird Hunter", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Red Crossbill", "Red-necked Phalarope", "Invincible Bird Hunter", "Vulnerable Bird Hunter 1", "Orange-bellied Parrot", "Invincible Bird Hunter", "Bird", "Bird", "Bird", "Bird", "Bird", "Vulnerable Bird Hunter 1" };

            foreach(string itemName in gameSequence)
            {
                int itemValue = scoringItem[itemName]; 

                if (itemName=="Invincible Bird Hunter")
                {
                    Console.WriteLine("You lost a life!\n" +
                    "\n" +
                    $"Lives: { drofsnar.Health += itemValue}        Points: { drofsnar.Points}");
                }
                else
                {
                Console.WriteLine($"You scored: {itemValue} pts.\n" +
                $"\n" +
                $"Lives: {drofsnar.Health}      Points: {drofsnar.Points += itemValue}");
                }
            }

            
            if(drofsnar.Health==0)
            {
                Console.WriteLine("GAME OVER!");
            }
            else if(drofsnar.Points>=10000)
            {
                drofsnar.Health += 1;
            }
            

        /*
         Console.Write("Type something: ");
         string itemName = Console.ReadLine();
         int itemValue; 

            switch (itemName)
            {
                case "Bird":
                    itemValue = scoringItem["Bird"];
                    break;
                case "Crested Ilbis":
                    itemValue = scoringItem["Crested Ilbis"];
                    break;
                case "Great Kiskudee":
                    itemValue = scoringItem["Great Kiskudee"];
                    break;
                case "Red Crossbill":
                    itemValue = scoringItem["Red Crossbill"];
                    break;
                case "Red-necked Phalarope":
                    itemValue = scoringItem["Red-necked Phalarope"];
                    break;
                case "Evening Grosbeak":
                    itemValue = scoringItem["Evening Grosbeak"];
                    break;
                case "Greater Prairie Chicken":
                    itemValue = scoringItem["Greater Prairie Chicken"];
                    break;
                case "Iceland Gull":
                    itemValue = scoringItem["Iceland Gull"];
                    break;
                case "Orange-Bellied Parrot":
                    itemValue = scoringItem["Orange-Bellied Parrot"];
                    break;
                    // if this case then print 
                    //Console.WriteLine("You lost a life!");
                    //Console.WriteLine($"Lives: {drofsnar.Health += itemValue} Points: {drofsnar.Points}");
                case "Invincible Bird Hunter":
                    itemValue = scoringItem["Invincible Bird Hunter"];
                    break;
                // Catch All
                default:
                    itemValue = 0;
                    break;
            }

            // Clear user input section
            Console.Clear();

            // Checking for Invincible Bird Hunter 
            if (output=="Invincible Bird Hunter") 
            {
                Console.WriteLine("You lost a life!\n" +
                    "\n" +
                    $"Lives: { drofsnar.Health += itemValue}        Points: { drofsnar.Points}");
                //Console.WriteLine($"Lives: {drofsnar.Health += itemValue} Points: {drofsnar.Points}");   // same as above
            }
            else
            {
            Console.WriteLine($"You scored: {itemValue} pts.\n" +
                $"\n" +
                $"Lives: {drofsnar.Health}      Points: {drofsnar.Points += itemValue}");
            //Console.WriteLine($"Lives: {drofsnar.Health} Points: {drofsnar.Points += itemValue}");  // same as above
            }

            Console.ReadLine();
            */
        }
    }
}
