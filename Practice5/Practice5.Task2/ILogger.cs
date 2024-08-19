//using Microsoft.Extensions.Logging;
using System;

namespace Practice5.Task2
{
  interface ILogger
    {
    void Trace(string message);
    void Info(string message);
    void Debug(string message);
    void Warning(string message);
    void Error(string message);
    void Fatal(string message);
    void Log(string message, LogLevel logLevel);
    }
  public enum LogLevel
  {
    Trace = 0,
    Debug = 1,
    Info = 2,
    Warning = 3,
    Error = 4,
    Fatal = 5
  }
}