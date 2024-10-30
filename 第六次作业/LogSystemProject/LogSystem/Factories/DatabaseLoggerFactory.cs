using LogSystem.Interfaces;
using LogSystem.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSystem.Factories
{
    public class DatabaseLoggerFactory : LoggerFactory
    {
        public override ILogger CreateLogger()
        {
            return new DatabaseLogger();
        }
    }
}
