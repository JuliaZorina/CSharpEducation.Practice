using System;

namespace Practice5.Task3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Dog dog = new Dog("Шарик", 5);
      Cat cat = new Cat("Пушок", 4);

      cat.MakeSound();
      dog.MakeSound();

    }
  }
}
