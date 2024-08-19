using System;

namespace Practice5.Task3
{
  public class Cat : Animal
  {
    public Cat(string name, int age)
      :base(name, age)
    {
    }

    public override void MakeSound()
    {
      Console.WriteLine("Meow!");
    }
  }
}
