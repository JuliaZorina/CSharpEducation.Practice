using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8.Task6
{
  public class Product
  {
    public string Name { get; set; }  
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
      this.Name = name;
      this.Price = price;
    }
  }
}
