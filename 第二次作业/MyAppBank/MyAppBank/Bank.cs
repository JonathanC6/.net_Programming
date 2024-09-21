using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppBank
{
    internal class Bank
    {
        private ATM atm = new ATM();

        public Bank()
        {
            atm.BigMoneyFetched += OnBigMoneyFetched;
        }

        private void OnBigMoneyFetched(object sender, BigMoneyArgs e)
        {
            Console.WriteLine($"[ALERT] Big withdrawal detected! Account: {e.AccountNumber}, Amount: {e.Amount}");
        }

        //模拟
        public void Start()
        {
            Account account = new CreditAccount("123456", 5000, 2000);

            try
            {
                atm.Withdraw(account, 20000);  //触发大额取款事件
            }
            catch (BadCashException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
