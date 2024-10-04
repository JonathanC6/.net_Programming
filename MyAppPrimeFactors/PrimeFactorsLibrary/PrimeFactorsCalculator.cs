using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorsLibrary
{
    public class PrimeFactorsCalculator
    {
        public string PrimeFactors(int number)
        {
            if (number < 2 || number > 1000)
            {
                throw new ArgumentOutOfRangeException("输入的整数需要在2-1000的范围内。");
            }

            List<int> factors = new List<int>();
            int divisor = 2;

            while (number > 1)
            {
                while (number % divisor == 0)
                {
                    factors.Add(divisor);
                    number /= divisor;
                }
                divisor++;
            }

            return string.Join(" × ", factors);
        }
    }
}
