using System;
using System.Security.Policy;

namespace Practice6.Task2
{
  public class BankAccount
  {
    #region Поля и свойства

    public decimal Money { get; set; }
    public decimal DepositMoney { get; set; }

    #endregion

    #region Методы

    /// <summary>
    /// Внести деньги на депозит.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывает исключение, если введенная сумма <0 или больше баланса.</exception>
    public void Deposit()
    {
      Console.WriteLine("Введите сумму, которую хотите положить на депозит");
      var deposit = decimal.Parse( Console.ReadLine());

      if (deposit < 0)
      {
        throw new ArgumentException("Сумма не может быть отрицалельной");
      }
      else if (deposit > this.Money)
      {
        throw new ArgumentException("Введеная сумма больше вашего баланса.");
      }
      else
      {
        this.DepositMoney = this.DepositMoney + deposit*(decimal)1.12;
        this.Money = this.Money-deposit;
        Console.WriteLine($"Баланс депозита: {this.DepositMoney}");
        Console.WriteLine($"Баланс счета: {this.Money}");
      }
      
    }
    /// <summary>
    /// Снять наличные.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывает исключение, если введенная сумма <0 или больше баланса.</exception>
    public void GetCash() 
    {
      Console.WriteLine($"Баланс:{this.Money}\nДепозит: {this.DepositMoney} \nВведите сумму, которую хотите снять.");
      var cash = decimal.Parse( Console.ReadLine());

      if (cash < 0)
      {
        throw new ArgumentException("Сумма не может быть отрицалельной");
      }
      else if (cash > this.Money)
      {
        throw new ArgumentException("Введеная сумма больше вашего баланса.");
      }
      else
      {
        Console.WriteLine($"Баланс : {this.Money-cash}");
      }
    }

    #endregion

    #region Конструкторы

    public BankAccount(decimal money)
    {
      this.DepositMoney = 0;
      this.Money = money;
    }

    #endregion
  }
}
