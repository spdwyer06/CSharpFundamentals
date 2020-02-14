using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges.Feb_11_Challenge
{
    public class ScoringItem
    {
        public ScoringItem(string itemName, int itemValue)
        {
            ItemName = itemName;
            ItemValue = itemValue;
        }
        public string ItemName { get; set; }
        public int ItemValue { get; set; }
        /*public override string ToString()
        {
            return $"Item Name: {ItemName} Item Value: {ItemValue}";
        }*/ 
        
           
    }


    

    
}
