using Practice5.Task2;
using System;
using System.IO;

namespace Practice6.Task4
{
  internal class GetFile
  {
    #region Поля и свойства

    public string Name { get; set; }

    #endregion

    #region Методы

    public void ReadFile()
    {
      var fileLogger = new FileLogger();
      string path = string.Empty;
      var dir = Directory.GetCurrentDirectory();
      path = Path.Combine(dir, this.Name);

      if (!File.Exists(path))
      {
        throw new FileNotFoundException($"Файл с именем {this.Name} не найден");
      }
      else
      {
        var fileInfo = new FileInfo(path);
        if (fileInfo.Length == 0)
        {
          throw new ArgumentNullException("Файл пуст");
        }
        else
        {
          if (IsFileLocked(path))
          {
            throw new IOException("Сейчас файл занят другим процессом, повторите попытку позднее");
          }
          else
          {
            Console.WriteLine(File.ReadAllText(path));
          }
        }
      }      
    }

    private static bool IsFileLocked(string path)
    {
      try
      {
        using (FileStream fs = new FileInfo(path).Open(FileMode.Open, FileAccess.Read, FileShare.None))
        {
          return false;
        }
      }
      catch (IOException)
      {
        return true;
      }
    }

    #endregion

    #region Конструкторы

    public GetFile(string name)
    {
      this.Name = name;
    }

    #endregion
  }
}
