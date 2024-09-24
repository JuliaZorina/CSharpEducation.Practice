using System;

namespace Practice8.Task6
{
  public class PurchaseEventArgs : EventArgs
  {
    public string PurchaseName { get; }
    public decimal PurchasePrice { get; }
    public string Message { get; }


    public PurchaseEventArgs(string name, decimal price) 
    { 
      this.PurchaseName = name;
      this.PurchasePrice = price;
      this.Message = $"Куплен товар {this.PurchaseName} по цене {this.PurchasePrice}";
    }
  }
}
