using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_WorkingWithDI
{
    class Transaction
    {
        private readonly ICurrency _currency;
        public Transaction(ICurrency currency)
        {
            _currency = currency;
            DateOfTransaction = DateTime.Now;
        }
        public DateTimeOffset DateOfTransaction { get; set; }  // look up DateTimeOffset
        public decimal GetAmount() => _currency.Value;
       /* {
            return _currency.Value;        // Same as above 
        } */
        public string GetTransactionType() => _currency.Name; 
    }
}
