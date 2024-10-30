using LogSystem.Decorators;
using LogSystem.Factories;
using LogSystem.Interfaces;
using LogSystem.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoggerFactory consoleLoggerFactory = new ConsoleLoggerFactory();
            ILogger consoleLogger = consoleLoggerFactory.CreateLogger();

            //使用装饰器增加时间戳
            ILogger timestampLogger = new TimestampLogger(consoleLogger);

            //使用观察者模式管理多个日志记录器
            LoggerManager loggerManager = new LoggerManager();
            loggerManager.AddLogger(timestampLogger);

            loggerManager.LogToAll("System startup");

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
