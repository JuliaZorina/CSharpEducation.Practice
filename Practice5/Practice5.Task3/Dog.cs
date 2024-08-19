using System;

namespace Practice5.Task3
{
  public class Dog : Animal
  {
    public Dog(string name, int age) 
      : base(name, age)
    {
      Console.WriteLine("An object of the 'Dog' class was created");
    }

    public override void MakeSound()
    {
      Console.WriteLine("Woof!");
    }
  }
}
