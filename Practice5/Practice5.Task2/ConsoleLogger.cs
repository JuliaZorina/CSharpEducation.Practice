using System;
using System.Diagnostics;

namespace Practice5.Task2
{
  public class ConsoleLogger : ILogger
  {
    public void Debug(string message)
    {
      var methodInfo = new StackFrame(1).GetMethod();
      var className = methodInfo.DeclaringType.Name;
      Console.WriteLine($"<{DateTime.Now}> | <{className}> | <{LogLevel.Debug}> | <{message}>");
    }

    public void Error(string message)
    {
      var methodInfo = new StackTrace().GetFrame(1).GetMethod();
      var className = methodInfo.ReflectedType.Name;
      Console.WriteLine($"<{DateTime.Now}> | <{className}> | <{LogLevel.Error}> | <{message}>");
    }

    public void Fatal(string message)
    {
      var methodInfo = new StackTrace().GetFrame(1).GetMethod();
      var className = methodInfo.ReflectedType.Name;
      Console.WriteLine($"<{DateTime.Now}> | <{className}> | <{LogLevel.Fatal}> | <{message}>");
    }

    public void Info(string message)
    {
      var methodInfo = new StackTrace().GetFrame(1).GetMethod();
      var className = methodInfo.ReflectedType.Name;
      Console.WriteLine($"<{DateTime.Now}> | <{className}> | <{LogLevel.Info}> | <{message}>");
    }

    public void Trace(string message)
    {
      var methodInfo = new StackTrace().GetFrame(1).GetMethod();
      var className = methodInfo.ReflectedType.Name;
      Console.WriteLine($"<{DateTime.Now}> | <{className}> | <{LogLevel.Trace}> | <{message}>");
    }

    public void Warning(string message)
    {
      var methodInfo = new StackTrace().GetFrame(1).GetMethod();
      var className = methodInfo.ReflectedType.Name;
      Console.WriteLine($"<{DateTime.Now}> | <{className}> | <{LogLevel.Warning}> | <{message}>");
    }

    public void Log(string message, LogLevel logLevel)
    {
      switch (logLevel)
      {
        case LogLevel.Debug:
          Debug(message);
          break;
        case LogLevel.Info:
          Info(message);
          break;
        case LogLevel.Warning:
          Warning(message);
          break;
        case LogLevel.Error:
          Error(message);
          break;
        case LogLevel.Fatal:
          Fatal(message);
          break;
        case LogLevel.Trace:
          Trace(message);
          break;
        default:
          throw new ArgumentException($"Неизвестный уровень логирования: {logLevel}");

      }
    }
  }
}
