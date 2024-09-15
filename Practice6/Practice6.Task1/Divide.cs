using System;
using Practice5.Task2;

namespace Practice6.Task1
{
  public class Divide
  {
    public static int DevideInt(string a, string b)
    {
      var fileLogger = new FileLogger();

      int parseA;
      int parseB;
      int c;

      if (!int.TryParse(a, out parseA))
      {
        throw new FormatException("Переменная a не является числом");
      }
      if (!int.TryParse(b, out parseB))
      {
        throw new FormatException("Переменная b не является числом");
      }
      if (parseB == 0) 
      {
        throw new DivideByZeroException("Нельзя делить на ноль");
      }

      c = parseA / parseB;

      return c;
    }
  }
}
