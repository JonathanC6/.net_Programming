using LogSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSystem.Loggers
{
    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            //模拟数据库日志记录
            System.Console.WriteLine($"Database Log: {message}");
        }
    }
}
