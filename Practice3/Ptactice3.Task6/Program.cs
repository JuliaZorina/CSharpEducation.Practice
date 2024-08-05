using System;

namespace Ptactice3.Task6
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var pointA = new Point();
      var pointB = new Point();
      pointA.X = 0;
      pointB.X = 10;
      pointA.Y = 0;
      pointB.Y = 10;

      Console.WriteLine(Distince(pointA, pointB));
    }

    public static double Distince(Point pointA, Point pointB)
    {
      return Math.Sqrt(Math.Pow((pointB.X - pointA.X), 2) + Math.Pow((pointB.Y - pointA.Y),2));
    }
  }
}
