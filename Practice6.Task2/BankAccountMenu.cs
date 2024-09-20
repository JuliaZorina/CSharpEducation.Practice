﻿using Practice5.Task2;
using System;

namespace Practice6.Task2
{
  public class BankAccountMenu
  {
    #region Методы

    /// <summary>
    /// Меню для взаимодействия пользователя с программой.
    /// </summary>
    public static void Menu(BankAccount bankAccount)
    {
      var consoleLogger = new ConsoleLogger();
      var fileLogger = new FileLogger();
      
      try
      {
        Console.WriteLine("Нажмите 1 для пополнения депозита.\n" +
          "Нажмите 2 для снятия наличных.\n" +
          "Нажмите 3 для выхода из программы.");

        var menu = Console.ReadLine();

        switch (menu)
        {
          case "1":
            bankAccount.Deposit();
            Menu(bankAccount);
            break;
          case "2":
            bankAccount.GetCash();
            Menu(bankAccount);
            break;
          case "3":
            Exit(bankAccount);
            break;
          default:
            Console.WriteLine("Введено некорректное значение!");
            Menu(bankAccount);
            break;
        }
      }
      catch (ArgumentException ex)
      {
        Console.WriteLine(ex + "\n");
        consoleLogger.Log(ex.Message, LogLevel.Error);
        fileLogger.Log(ex.Message, LogLevel.Error);

        BankAccountMenu.Menu(bankAccount);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex + "\n");
        consoleLogger.Log(ex.Message, LogLevel.Error);
        fileLogger.Log(ex.Message, LogLevel.Error);

        BankAccountMenu.Menu(bankAccount);
      }
    }
    /// <summary>
    /// Выйти из программы.
    /// </summary>
    private static void Exit(BankAccount bankAccount)
    {
      Console.WriteLine("Вы действительно хотите выйти из программы? [y/n]");
      var exit = Console.ReadLine();

      if (exit == "y")
        Console.WriteLine("Выход из программы...");
      else if (exit == "n")
        BankAccountMenu.Menu(bankAccount);
      else
      {
        Console.WriteLine("Введено некорректное значение!");
        Exit(bankAccount);
      }
    }
  }
  #endregion
}

