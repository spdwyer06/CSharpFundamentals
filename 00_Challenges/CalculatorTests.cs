using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_ShouldAddBothNumbers()
        {
            double expected = 5;
            double actual = Calculator.Add(2.5, 2.5);
            Assert.AreEqual(expected, actual); 
        }

        [TestMethod]
        public void Subtract_ShouldSubtractNumbers()
        {
            Calculator subtract = new Calculator();

            double expected = 4;
            double actual = subtract.Subtract(5, 1); 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Multiply()
        {
            Calculator multiply = new Calculator();

            double expected = 4;
            double actual = multiply.Multiply(2, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Divide()
        {
            Calculator divide = new Calculator();

            double expected = 2;
            double actual = divide.Divide(4, 2);
            Assert.AreEqual(expected, actual);
        }
    }
}
