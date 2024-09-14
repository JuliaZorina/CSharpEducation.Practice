using System;

namespace Practice6.Task1
{
  internal class Program
  {
    static void Main(string[] args)
    {
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
        Console.WriteLine(ex.ToString());
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
