using System;

namespace Practice5.Task3
{
  public class Cat : Animal
  {
    public Cat(string name, int age)
      :base(name, age)
    {
      Console.WriteLine("An object of the 'Cat' class was created");
    }

    public override void MakeSound()
    {
      Console.WriteLine("Meow!");
    }
  }
}
