using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppBank
{
    internal class BadCashException : Exception
    {
        public BadCashException(string message) : base(message) { }
    }
}
