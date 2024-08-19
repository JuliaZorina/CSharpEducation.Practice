using System;
using System.Diagnostics;
using System.IO;

namespace Practice5.Task2
{
  public class FileLogger: ILogger
  {
    public void Trace(string message)
    {
      Log(message, LogLevel.Trace);
    }

    public void Info(string message)
    {
      Log(message, LogLevel.Info);
    }

    public void Debug(string message)
    {
      Log(message, LogLevel.Debug);
    }

    public void Warning(string message)
    {
      Log(message, LogLevel.Warning);
    }

    public void Error(string message)
    {
      Log(message, LogLevel.Error);
    }

    public void Fatal(string message)
    {
      Log(message, LogLevel.Fatal); ;
    }

    public void Log(string message, LogLevel logLevel)
    {
      var dir = Directory.GetCurrentDirectory();
      var path = Path.Combine(dir, "log.txt");
      var methodInfo = new StackTrace().GetFrame(1).GetMethod();
      var className = methodInfo.ReflectedType.Name;

      FileInfo file = new FileInfo(path);

      if (!file.Exists)
      {
        FileStream fileStream = file.Create();
        fileStream.Close();
      }

      using (StreamWriter sw = new StreamWriter(path, true))
      {
        sw.WriteLine($"<{DateTime.Now}> | <{className}> | <{logLevel}> | <{message}>");
        sw.Close();
      }
    }

  }
}
