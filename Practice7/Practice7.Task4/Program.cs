using System;

namespace Practice7.Task4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var numbers = new Numbers();

      foreach (var number in numbers.GetEvenNumbers(0, 10))
      {
        Console.WriteLine(number);
      }
    }
  }
}
