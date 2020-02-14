using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_InterfacesIntroduction
{
    public interface IFruit // The "I" stands for interface  // Interfaces are always public  // Interfaces are a set of guidelines/rules  // Interfaces are also known as "contracts"
    {
        // No Access Modifiers needed when declaring Interface Properties, everything will be public since it's an Interface
        // All properties declared in an interface MUST be fullfilled
        string Name { get; }  // i.e. must have a string Property "Name" 
        bool Peeled { get; }
        string Peel(); // must have a Method named "Peel" with a string return type
    }


}
