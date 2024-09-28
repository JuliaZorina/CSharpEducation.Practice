using System;

namespace Practice8.Task3
{
  public class BankAccount
  {
    private decimal balance;

    public decimal Balance 
    {
      get 
      {
        return this.balance;
      }
      set 
      {
        if (value > 0)
          this.balance = value; 
      } 
    }

    private void GetCash(decimal cash)
    {
      if (cash > this.balance)
        throw new Exception($"Запрашиваемая сумма больше вашего баланса.\nБаланс: {this.balance}");
      else
      {
        this.balance -= cash;
        Console.WriteLine($"Со счета снято {cash}\nБаланс: {this.balance}");
      }
    }

    private void ReplenishBalance(decimal money)
    {
      if (money <= 0)
        throw new Exception($"Введенная сумма не может быть меньше 0.\nБаланс: {this.balance}");
      else
      {
        this.balance += money;
        Console.WriteLine($"Баланс пополен на {money}.\nБаланс: {this.balance}");
      } 
    }

    public void GetTransaction(decimal amount, TransactionType transactionType)
    {
      AccountTransactionDelegate accountTransaction = TransactionMenu;
      accountTransaction(amount, transactionType);
    }

    private void TransactionMenu(decimal sum, TransactionType transactionType)
    {
      switch (transactionType)
      {
        case TransactionType.GetCash:
          GetCash(sum); 
          break;
        case TransactionType.ReplenishBalance:
          ReplenishBalance(sum); 
          break;
      }
    }

    public BankAccount(decimal balance)
    { 
      this.balance = balance;
    }
  }

  public delegate void AccountTransactionDelegate(decimal sum, TransactionType transactionType);

  public enum TransactionType
  {
    GetCash,
    ReplenishBalance
  }
}
