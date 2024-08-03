using System;

namespace Practice3.Task3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var calculator = new Calculator();

      Console.WriteLine(calculator.Addition(5, 6));
      Console.WriteLine(calculator.Subtraction(5, 6));
      Console.WriteLine(calculator.Multiply(5, 6));
      Console.WriteLine(calculator.Divide(5, 1));
    }
  }
}
