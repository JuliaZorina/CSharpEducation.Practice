using Practice5.Task2;
using System;
using System.IO;
namespace Practice6.Task1
{
  /// <summary>
  /// Класс для поиска и считывания файла. 
  /// </summary>
  public class ReadFile
  {
    #region Поля и свойства

    private string fileName;
    public string FileName { get; set; }

    #endregion

    #region Методы
    /// <summary>
    /// Получить файл и из полученного файла получить числа, если они там есть.
    /// </summary>
    /// <param name="a">Делимое.</param>
    /// <param name="b">Делитель.</param>
    /// <exception cref="FileNotFoundException">Выбрасывает исключение, если файл не был найден.</exception>
    /// <exception cref="ArgumentException">Выбрасывает исключение, если файл пуст 
    /// или не содержит нужного для операции количества чисел</exception>
    public void GetNumbersFromFile(ref string a, ref string b)
    {
      var fileLogger = new FileLogger();
      string path = string.Empty;
      var dir = Directory.GetCurrentDirectory();
      path = Path.Combine(dir, this.FileName);

      if (!File.Exists(path))
      {
        throw new FileNotFoundException($"Файл с именем {this.FileName} не найден");
      }

      var numbers = File.ReadAllText(path);
      var numbersArray = numbers.Trim().Split(' ');

      if (numbersArray.Length != 2)
      {
        throw new ArgumentException("Файл пуст или не содержит нужного для операции количества чисел");
      }
      else
      {
        a = numbersArray[0];
        b = numbersArray[1];
      }
    }

    #endregion

    #region Конструторы

    public ReadFile(string fileName)
    {
      this.FileName = fileName;
    }

    #endregion
  }
}
