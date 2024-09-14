using System;

namespace Practice6.Task1
{
  public class Divide
  {
    public static int DevideInt(string a, string b)
    {
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
        throw new DivideByZeroException("Нельзя делить на ноль", ex);
      }
      catch (Exception ex) 
      {
        throw new Exception("Переменная a не является числом", ex);
      } 
      return c;
    }
  }
}
