using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppBank
{
    internal class ATM
    {
        public delegate void BigMoneyHandler(object sender, BigMoneyArgs e);
        public event BigMoneyHandler BigMoneyFetched;

        private Random random = new Random();

        public void Withdraw(Account account, decimal amount)
        {
            //模拟坏钞率
            if (random.Next(1, 101) <= 30)
            {
                throw new BadCashException("Detected damaged cash.");
            }

            account.Withdraw(amount);

            if (amount > 10000 && BigMoneyFetched != null)
            {
                BigMoneyFetched(this, new BigMoneyArgs(account.AccountNumber, amount));
            }
        }

    }
}
