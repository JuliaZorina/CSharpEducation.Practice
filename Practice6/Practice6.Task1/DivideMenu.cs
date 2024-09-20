using Practice5.Task2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6.Task1
{
  public class DivideMenu
  {
    public static void Menu()
    {
      var consoleLogger = new ConsoleLogger();
      var fileLogger = new FileLogger();
      try
      {
        string a = string.Empty;
        string b = string.Empty;

        Console.WriteLine("Нажмите 1 для деления чисел.\n" +
            "Нажмите 2 для выхода из программы.");

        var menu = Console.ReadLine();

        switch (menu)
        {
          case "1":
            GetFile(ref a, ref b);
            Menu();
            break;
          case "2":
            Exit();
            break;
          default:
            Console.WriteLine("Введено некорректное значение!");
            Menu();
            break;
        }
      }
      catch (DivideByZeroException ex)
      {
        Console.WriteLine(ex + "\n");
        consoleLogger.Log(ex.Message, LogLevel.Error);
        fileLogger.Log(ex.Message, LogLevel.Error);

        DivideMenu.Menu();
      }
      catch (FormatException ex)
      {
        Console.WriteLine(ex + "\n");
        consoleLogger.Log(ex.Message, LogLevel.Error);
        fileLogger.Log(ex.Message, LogLevel.Error);

        DivideMenu.Menu();
      }
      catch (ArgumentNullException ex)
      {
        Console.WriteLine(ex + "\n");
        consoleLogger.Log(ex.Message, LogLevel.Error);
        fileLogger.Log(ex.Message, LogLevel.Error);

        DivideMenu.Menu();
      }
      catch (FileNotFoundException ex)
      {
        Console.WriteLine(ex + "\n");
        consoleLogger.Log(ex.Message, LogLevel.Error);
        fileLogger.Log(ex.Message, LogLevel.Error);

        DivideMenu.Menu();
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex + "\n");
        consoleLogger.Log(ex.Message, LogLevel.Error);
        fileLogger.Log(ex.Message, LogLevel.Error);

        DivideMenu.Menu();
      }

    }
    /// <summary>
    /// Выйти из программы.
    /// </summary>
    private static void Exit()
    {
      Console.WriteLine("Вы действительно хотите выйти из программы? [y/n]");
      var exit = Console.ReadLine();

      if (exit == "y")
        Console.WriteLine("Выход из программы...");
      else if (exit == "n")
        DivideMenu.Menu();
      else
      {
        Console.WriteLine("Введено некорректное значение!");
        Exit();
      }
    }

    private static void GetFile(ref string a, ref string b)
    {
      Console.WriteLine("Введите название файла с расширением");
      string file = Console.ReadLine();
      var getFile = new ReadFile(file);
      getFile.GetNumbersFromFile(ref a, ref b);
      Console.WriteLine($"Результат:{Divide.DevideInt(a, b)}");
    }
  }
}
