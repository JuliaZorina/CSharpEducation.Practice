using System;

namespace Practice6.Task2
{
  internal class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Введите начальный баланс счета");
      var money = decimal.Parse(Console.ReadLine());
      var bankAccount = new BankAccount(money);
      BankAccountMenu.Menu(bankAccount);
    }
  }
}
