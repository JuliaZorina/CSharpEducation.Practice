using System;

namespace Practice3.Task10
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var car = new Car()
      {
        brand = "Porsche"
      };
      GetBrand(car);
    }

    public static void GetBrand(Car car)
    {
      Console.WriteLine($"Марка машины: {car.brand}");
    }
  }  
}
