using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _09_Interfaces_WorkingWithDI  // "DI" stands for Dependency Injection
{
    [TestClass]
    public class CurrencyTest
    {
        [TestMethod]
        public void PennyTests()
        {
            ICurrency penny = new Penny();
            Assert.AreEqual(0.01m, penny.Value);
            Assert.AreEqual("Penny", penny.Name);
        }

        [TestMethod]
        public void NickelTests()
        {
            ICurrency nickel = new Nickel();
            Assert.AreEqual(0.05m, nickel.Value);
            Assert.AreEqual("Nickel", nickel.Name);
        }

        [TestMethod]
        public void DimeTests()
        {
            ICurrency dime = new Dime();
            Assert.AreEqual(0.10m, dime.Value);
            Assert.AreEqual("Dime", dime.Name);
        }

        [TestMethod]
        public void QuarterTests()
        {
            ICurrency quarter = new Quarter();
            Assert.AreEqual(0.25m, quarter.Value);
            Assert.AreEqual("Quarter", quarter.Name);
        }

        [TestMethod]
        public void DollarTests()
        {
            ICurrency dollar = new Dollar();
            Assert.AreEqual(1, dollar.Value);
            Assert.AreEqual("Dollar", dollar.Name);
        }

        [TestMethod]
        public void FiveDollarTests()
        {
            ICurrency fiveDollar = new FiveDollar();
            Assert.AreEqual(5, fiveDollar.Value);
            Assert.AreEqual("Five Dollar", fiveDollar.Name);
        }

        [TestMethod]
        public void TenDollarTests()
        {
            ICurrency tenDollar = new TenDollar();
            Assert.AreEqual(10, tenDollar.Value);
            Assert.AreEqual("Ten Dollar", tenDollar.Name);
        }

        [TestMethod]
        public void TwentyDollarTests()
        {
            ICurrency twentyDollar = new TwentyDollar();
            Assert.AreEqual(20, twentyDollar.Value);
            Assert.AreEqual("Twenty Dollar", twentyDollar.Name);
        }

        [TestMethod]
        public void FiftyDollarTests()
        {
            ICurrency fiftyDollar = new FiftyDollar();
            Assert.AreEqual(50, fiftyDollar.Value);
            Assert.AreEqual("Fifty Dollar", fiftyDollar.Name);
        }

        [TestMethod]
        public void HundredDollarTests()
        {
            ICurrency hundredDollar = new HundredDollar();
            Assert.AreEqual(100, hundredDollar.Value);
            Assert.AreEqual("Hundred Dollar", hundredDollar.Name);
        }

        [DataTestMethod] // Declared Decimal Types do NOT work in these methods, must be converted to work
        [DataRow(100.2)]
        [DataRow(37.12)]
        [DataRow(2319.18)]
        [DataRow(1408.0)]
        public void EPaymentTest(double value)
        {
            decimal convertedValue = Convert.ToDecimal(value);
            var ePayment = new ElectronicPayment(convertedValue);
            Assert.AreEqual(convertedValue, ePayment.Value);
            Assert.AreEqual("Electronic Payment", ePayment.Name);
        }
    }
}
