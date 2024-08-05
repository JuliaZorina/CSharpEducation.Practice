using System;

namespace Practice3.Task3
{
  class Calculator
  {
    public double Addition(int a, int b)
    {
      return a + b;
    }

    public double Subtraction(int a, int b)
    {
      return a - b;
    }

    public double Divide(int a, int b)
    {
      if (b == 0)
      {
        throw new ArgumentException("Нельзя делить на 0!");
      }
      else
      {
        return a / b;
      }
    }

    public double Multiply(int a, int b)
    {
      return a * b;
    }
  }
}
