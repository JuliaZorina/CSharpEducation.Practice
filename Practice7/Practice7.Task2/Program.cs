using System;

namespace Practice7.Task2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var person = new Person("Вася", 17);
      var person2 = person.Clone() as Person;
      Console.WriteLine(person2.Age);

      var rect = new Rectangle();
      rect.Width = 100;
      rect.Height = 150;
      var rect2 = rect.Clone() as Rectangle;
      Console.WriteLine(rect.Width);
      Console.WriteLine(rect.Height);


    }
  }
}
