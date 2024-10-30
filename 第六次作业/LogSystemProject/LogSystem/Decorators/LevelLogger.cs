using LogSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSystem.Decorators
{
    public class LevelLogger : LoggerDecorator
    {
        private readonly string _level;

        public LevelLogger(ILogger logger, string level) : base(logger)
        {
            _level = level;
        }

        public override void Log(string message)
        {
            //假设日志级别以 "INFO", "WARNING", "ERROR" 等格式传递
            if (message.StartsWith(_level))
            {
                base.Log(message);
            }
        }
    }
}
