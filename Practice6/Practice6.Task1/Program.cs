using System;
using Practice5.Task2;

namespace Practice6.Task1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var consoleLogger = new ConsoleLogger();
      

      Console.WriteLine("Введите число a");
      var a = Console.ReadLine();
      Console.WriteLine("Введите число b");
      var b = Console.ReadLine();

      try
      {
        Console.WriteLine($"Результат:{Divide.DevideInt(a, b)}");
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        consoleLogger.Log(ex.Message, LogLevel.Error);
      }
      finally
      {
        Console.WriteLine("Введите корректные данные");
        Console.WriteLine("Введите число a");
        a = Console.ReadLine();
        Console.WriteLine("Введите число b");
        b = Console.ReadLine();
        Console.WriteLine($"Результат:{Divide.DevideInt(a, b)}");
      }
    }
  }
}
