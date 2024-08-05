using System;

namespace Practice3.Task8
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*var rectangle = new Rectangle()
      {
        width = 10,
        height = 13
      };*/

      var rectangle = new Rectangle();
      Console.WriteLine("Введите ширину прямоугольника");
      rectangle.width = double.Parse(Console.ReadLine());
      Console.WriteLine("Введите высоту прямоугольника");
      rectangle.height = double.Parse(Console.ReadLine());

      Console.WriteLine($"Площадь прямоугольника равна {GetRectangleArea(rectangle)}");
    }

    private static double GetRectangleArea(Rectangle rectangle)
    {
      return rectangle.height*rectangle.width;
    }
  }
}
