using System;

namespace Practice8.Task6
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var purchase = new Purchase();
      purchase.PurchaseCompleted += OnPurchaseCompleted;

      purchase.GetPurchase(new Product("Огурцы", 50));
      purchase.GetPurchase(new Product("Помидоры", 70));
      purchase.GetPurchase(new Product("Сыр", 180));
      purchase.GetPurchase(new Product("Колбаса", 350));

    }

    private static void OnPurchaseCompleted(Purchase sender, PurchaseEventArgs args)
    {
      Console.WriteLine(args.Message);
    }
  }
}
