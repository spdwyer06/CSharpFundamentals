using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes
{
    public class Customer: Person // Class inheritance (ClassName : Class you're inheriting from) private values do NOT get inherited
    {
        public bool IsPremium { get; set; }
    }
}
