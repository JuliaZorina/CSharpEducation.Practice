using System;

namespace Practice6.Task2
{
  internal class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Введите начальный баланс счета");
      var money = decimal.Parse(Console.ReadLine());
      Console.WriteLine("Выберите вариант счета, который необходимо создать.\n" +
        "Нажмите 1, если хотите создать обычный банковский счет.\n" +
        "Нажмите 2, если хотите создать накопительный банковский счет.\n");
      var accountType = int.Parse(Console.ReadLine());
      switch (accountType)
      {
        case 1:
          var bankAccount = new BankAccount(money);
          BankAccountMenu<BaseBankAccount>.Menu(bankAccount);
          break;
          case 2:
          var savingsAccount = new SavingsAccount(money);
          BankAccountMenu<SavingsAccount>.Menu(savingsAccount);
          break;
      }
    }
  }
}
