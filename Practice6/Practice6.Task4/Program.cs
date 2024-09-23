using System;
using System.IO;

namespace Practice6.Task4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      try
      {
        Console.WriteLine("Введите название файла с расширением");
        var file = new GetFile(Console.ReadLine());
        file.ReadFile();
      }
      catch (FileNotFoundException ex)
      {
        Console.WriteLine(ex.ToString());
      }
      catch (ArgumentNullException ex)
      {
        Console.WriteLine(ex.ToString());
      }
      catch (IOException ex)
      {
        Console.WriteLine(ex.ToString());
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
    }
  }
}
