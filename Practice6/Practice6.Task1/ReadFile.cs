using Practice5.Task2;
using System;
using System.IO;
using System.Linq;

namespace Practice6.Task1
{
  public class ReadFile
  {
    private string fileName;
    public string FileName { get; set; }

    public ReadFile(string fileName) {
      this.FileName = fileName;
    }

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
  }
}
