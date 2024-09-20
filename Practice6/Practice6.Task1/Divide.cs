using System;
using Practice5.Task2;

namespace Practice6.Task1
{
  /// <summary>
  /// Класс выполнения целочисленного деления.
  /// </summary>
  public class Divide
  {
    #region Методы

    /// <summary>
    /// Выполнить целочисленное деление числа a на число b.
    /// </summary>
    /// <param name="a">Делимое.</param>
    /// <param name="b">Делитель</param>
    /// <returns>Возвращает результат деления.</returns>
    /// <exception cref="FormatException">Выбрасывает исключение, если строка a или b не являются числами.</exception>
    /// <exception cref="DivideByZeroException">Выбрасывает исключение, если была попытка деления на 0.</exception>
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

    #endregion
  }
}
