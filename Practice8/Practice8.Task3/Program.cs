using System;

namespace Practice8.Task3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var bankAccount = new BankAccount((decimal)10000);

      bankAccount.GetTransaction(500, TransactionType.GetCash);
      bankAccount.GetTransaction(100, TransactionType.ReplenishBalance);
    }
  }
}
