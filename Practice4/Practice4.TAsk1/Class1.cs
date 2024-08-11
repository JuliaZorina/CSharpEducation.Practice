using System;
namespace Practice4.Task1
{
  public class MathHelper
  {
    public int Add(int a, int b)
    {
      return a + b;
    }
    public int Multiply(int a, int b)
    {
      return a * b;
    }
    public int Substract(int a, int b)
    {
      return a - b;
    }
    public int Divide(int a, int b)
    {
      int res;
      if (b == 0)
        throw new ArgumentException("На ноль делить нельзя!");
      else res = a / b;
      return res;
    }
  }
}