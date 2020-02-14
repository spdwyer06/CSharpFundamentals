using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_WorkingWithDI
{
    [TestClass]
    public class TransactionTests
    {
        private decimal _debt;
        private void PayDebt(ICurrency payment)
        {
            _debt -= payment.Value;
            Console.WriteLine($"You have paid ${payment.Value} towards your debt.");
        }

        [TestInitialize] //  used to run code before running each test, usually it is used to prepare aspects of the environment in which your unit test will run and to establish a known state for running your test.
        public void Arrange()
        {
            _debt = 9080.30m;
        }

        [TestMethod]
        public void PayDebtTest()
        {
            PayDebt(new Dollar());
            PayDebt(new ElectronicPayment(450));
            decimal expectedDebt = 9080.30m - 451;
            Assert.AreEqual(expectedDebt, _debt);
        }

        [TestMethod]
        public void InjectingIntoConstructors()
        {
            var fiveDollar = new FiveDollar();
            var ePayment = new ElectronicPayment(123.40m);
            var firstTransaction = new Transaction(fiveDollar);
            var secondTransaction = new Transaction(ePayment);
            Console.WriteLine(firstTransaction.GetTransactionType());
            Console.WriteLine(secondTransaction.GetTransactionType());
            Assert.AreEqual("Five Dollar", firstTransaction.GetTransactionType());
            Assert.AreEqual("Electronic Payment", secondTransaction.GetTransactionType());

            Assert.AreEqual(123.40m, secondTransaction.GetAmount());
        }

        [TestMethod]
        public void MoreExamples()
        {
            var list = new List<Transaction>
            {
                new Transaction(new Dollar()),
                new Transaction(new ElectronicPayment(231.95m)),
                new Transaction(new FiveDollar()),
                new Transaction(new TwentyDollar())
            };

            foreach (var transaction in list)
            {
                var type = transaction.GetTransactionType();
                var amount = transaction.GetAmount();
                Console.WriteLine($"{type} ${amount} {transaction.DateOfTransaction}");
            }
        }
    }
}
