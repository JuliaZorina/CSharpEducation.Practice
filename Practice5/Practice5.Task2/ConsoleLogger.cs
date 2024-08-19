using System;
using System.Diagnostics;

namespace Practice5.Task2
{
  public class ConsoleLogger : ILogger
  {
    public void Debug(string message)
    {
      Log(message, LogLevel.Debug);
    }

    public void Error(string message)
    {
      Log(message, LogLevel.Error);
    }

    public void Fatal(string message)
    {
      Log(message, LogLevel.Fatal);
    }

    public void Info(string message)
    {
      Log(message, LogLevel.Info);
    }

    public void Trace(string message)
    {
      Log(message, LogLevel.Trace);
    }

    public void Warning(string message)
    {
      Log(message, LogLevel.Warning);
    }

    public void Log(string message, LogLevel logLevel)
    {
      var methodInfo = new StackTrace().GetFrame(1).GetMethod();
      var className = methodInfo.ReflectedType.Name;
      Console.WriteLine($"<{DateTime.Now}> | <{className}> | <{logLevel}> | <{message}>");
    }
  }
}
