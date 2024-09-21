using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.Start();
            Console.ReadKey();
        }
    }
}
