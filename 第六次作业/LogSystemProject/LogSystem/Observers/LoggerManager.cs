using LogSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSystem.Observers
{
    public class LoggerManager
    {
        private readonly List<ILogger> _loggers = new List<ILogger>();

        public void AddLogger(ILogger logger)
        {
            _loggers.Add(logger);
        }

        public void RemoveLogger(ILogger logger)
        {
            _loggers.Remove(logger);
        }

        public void LogToAll(string message)
        {
            foreach (var logger in _loggers)
            {
                logger.Log(message);
            }
        }
    }
}
