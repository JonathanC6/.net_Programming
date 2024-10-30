using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSystem.Factories
{
    public abstract class LoggerFactory
    {
        public abstract Interfaces.ILogger CreateLogger();
    }
}
