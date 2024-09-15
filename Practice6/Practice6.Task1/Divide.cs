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
      try
      {
        parseA = int.Parse(a);
        parseB = int.Parse(b);
        c = parseA / parseB;
      }
      catch (DivideByZeroException ex)
      {
        fileLogger.Log(ex.Message, LogLevel.Error);
        throw new DivideByZeroException("Нельзя делить на ноль", ex);
      }
      catch (Exception ex) 
      {
        fileLogger.Log(ex.Message, LogLevel.Error);
        throw new Exception("Переменная a не является числом", ex);
      } 
      return c;
    }
  }
}
