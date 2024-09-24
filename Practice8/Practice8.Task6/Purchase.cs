using System;
using System.Collections.Generic;

namespace Practice8.Task6
{
  public class Purchase
  {
    public List<Product> PurchaseList { get; set; }

    public event Action<Purchase, PurchaseEventArgs> PurchaseCompleted;
     
    public void GetPurchase(Product product)
    {
      PurchaseList.Add(product);
      PurchaseCompleted?.Invoke(this, new PurchaseEventArgs(product.Name, product.Price));
    }

    public Purchase()
    {
      this.PurchaseList = new List<Product>();
    }
  }
}
