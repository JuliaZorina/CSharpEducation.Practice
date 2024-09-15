using System;
using Practice5.Task2;

namespace Practice6.Task1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var consoleLogger = new ConsoleLogger();
      var fileLogger = new FileLogger();

      Console.WriteLine("Введите название файла с расширением");
      string file = Console.ReadLine();
      var getFile = new ReadFile(file);

      string a = string.Empty;
      string b = string.Empty;

      try
      {
        getFile.GetNumbersFromFile(ref a, ref b);
        Console.WriteLine($"Результат:{Divide.DevideInt(a, b)}");
      }
      catch (DivideByZeroException ex)
      {
        Console.WriteLine(ex + "\n");
        consoleLogger.Log(ex.Message, LogLevel.Error);
        fileLogger.Log(ex.Message, LogLevel.Error);
      }
      catch (FormatException ex)
      {
        Console.WriteLine(ex + "\n");
        consoleLogger.Log(ex.Message, LogLevel.Error);
        fileLogger.Log(ex.Message, LogLevel.Error);
      }
      catch (ArgumentNullException ex)
      {
        Console.WriteLine(ex + "\n");
        consoleLogger.Log(ex.Message, LogLevel.Error);
        fileLogger.Log(ex.Message, LogLevel.Error);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex + "\n");
        consoleLogger.Log(ex.Message, LogLevel.Error);
        fileLogger.Log(ex.Message, LogLevel.Error);
      }
      finally
      {
        //Console.WriteLine("\nВведите корректные данные");
        /*Console.WriteLine("Введите число a");
        var a = Console.ReadLine();
        Console.WriteLine("Введите число b");
        var b = Console.ReadLine();
        Console.WriteLine($"Результат:{Divide.DevideInt(a, b)}");*/ 
      }
    }
  }
}
