using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeFactorsLibrary;

namespace PrimeFactorsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrimeFactorsCalculator calculator = new PrimeFactorsCalculator();

            Console.WriteLine("输入一个在 2-1000 范围内的整数：");
            int number = int.Parse(Console.ReadLine());

            try
            {
                string result = calculator.PrimeFactors(number);
                Console.WriteLine(number + $" 的质因数为：{result} = {number}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
