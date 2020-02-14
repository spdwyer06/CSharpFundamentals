using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_WorkingWithDI
{
    public class Penny : ICurrency
    {
        public string Name
        {
            get{return "Penny";}
        }
        public decimal Value
        {
            get { return 0.01m; }
        }
    }

    public class Nickel : ICurrency
    {
        public string Name
        {
            get { return "Nickel"; }
        }
        public decimal Value
        {
            get { return 0.05m; }
        }
    }

    public class Dime : ICurrency
    {
        public string Name
        {
            get { return "Dime"; }
        }
        public decimal Value
        {
            get { return 0.10m; }
        }
    }

    public class Quarter : ICurrency
    {
        public string Name
        {
            get { return "Quarter"; }
        }
        public decimal Value
        {
            get { return 0.25m; }
        }
    }

    public class Dollar : ICurrency
    {
        public string Name
        {
            get { return "Dollar"; }
        }
        public decimal Value
        {
            get { return 1; }
        }
    }

    public class FiveDollar : ICurrency
    {
        public string Name
        {
            get { return "Five Dollar"; }
        }
        public decimal Value
        {
            get { return 5; }
        }
    }

    public class TenDollar : ICurrency
    {
        public string Name
        {
            get { return "Ten Dollar"; }
        }
        public decimal Value
        {
            get { return 10; }
        }
    }

    public class TwentyDollar : ICurrency
    {
        public string Name
        {
            get { return "Twenty Dollar"; }
        }
        public decimal Value
        {
            get { return 20; }
        }
    }

    public class FiftyDollar : ICurrency
    {
        public string Name
        {
            get { return "Fifty Dollar"; }
        }
        public decimal Value
        {
            get { return 50; }
        }
    }

    public class HundredDollar : ICurrency
    {
        public string Name
        {
            get { return "Hundred Dollar"; }
        }
        public decimal Value
        {
            get { return 100; }
        }
    }

    public class ElectronicPayment : ICurrency
    {
        public ElectronicPayment(decimal value)
        {
            Value = value;
        }
        public string Name
        {
            get { return "Electronic Payment"; }
        }
        public decimal Value { get; } // Needs a constructor to be set INSIDE the class
    }
}
