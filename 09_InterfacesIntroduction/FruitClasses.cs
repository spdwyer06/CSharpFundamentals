using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_InterfacesIntroduction
{
    public class Apple : IFruit 
    {
        // All properties declared in the Interface must be public in the Class using the Interface
        // Can add extra Properties to the Class, so long as the Interface Properties are included (Compare the Peeled property in the Class vs Interface)

        public Apple() { }
        public Apple(bool isPeeled)
        {
            Peeled = isPeeled;
        }
        public string Name { get { return "Apple"; } }
        public bool Peeled { get; private set; } // private set means that it can only be set WITHIN the Class
        public string Peel()
        {
            Peeled = true;
            return "You peel the apple";
        }
    }

    public class Orange : IFruit
    {
        public Orange() { }
        public Orange(bool isPeeled)
        {
            Peeled = isPeeled;
        }
        public string Name { get { return "Orange"; } }
        public bool Peeled { get; private set; }
        public string Peel()
        {
            Peeled = true;
            return "You peel the orange";
        }
        public string Zest()
        {
            if(Peeled)
            {
                return "Why are you doing this?";
            }
            return "You zest the orange for flavor";
        }
    }
    
    public class Grape : IFruit
    {
        public Grape() { }
        public Grape (bool isPeeled)
        {
            Peeled = isPeeled;
        }
        public string Name { get { return "Grape"; } }
        public bool Peeled { get; private set; }
        public string Peel()
        {
            return "Who peels grapes?";  // Peeled right now is set to "false"  (booleans are false by default)
        }
    }
}
