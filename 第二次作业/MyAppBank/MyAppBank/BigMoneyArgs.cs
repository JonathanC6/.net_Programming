using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppBank
{
    internal class BigMoneyArgs : EventArgs
    {
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }

        public BigMoneyArgs(string accountNumber, decimal amount)
        {
            AccountNumber = accountNumber;
            Amount = amount;
        }
    }
}
