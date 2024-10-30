using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LogSystem.Factories;
using LogSystem.Interfaces;
using LogSystem.Observers;
using NUnit.Framework;

namespace Tests
{
    [TestClass]
    public class LoggerTests
    {
        [Test]
        public void ConsoleLogger_ShouldLogMessage()
        {
            LoggerFactory factory = new ConsoleLoggerFactory();
            ILogger logger = factory.CreateLogger();

            //这里只是调用Log方法，检查日志输出的格式或内容
            logger.Log("Test log message");
        }

        [Test]
        public void LoggerManager_ShouldLogToAllLoggers()
        {
            LoggerManager loggerManager = new LoggerManager();
            LoggerFactory factory = new ConsoleLoggerFactory();
            ILogger logger = factory.CreateLogger();

            loggerManager.AddLogger(logger);
            loggerManager.LogToAll("Test message to all loggers");
        }
    }
}
