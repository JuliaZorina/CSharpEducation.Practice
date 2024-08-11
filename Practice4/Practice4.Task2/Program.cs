using System;
using Practice4.Task1;

namespace Practice4.Task2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var mathHelper = new MathHelper();
      Console.WriteLine( mathHelper.Add(10, 5));
      Console.WriteLine( mathHelper.Divide(10, 5));
      Console.WriteLine( mathHelper.Multiply(10, 5));
      Console.WriteLine( mathHelper.Substract(10, 5));
    }
  }
}
