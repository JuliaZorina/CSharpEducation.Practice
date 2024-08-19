using System;

namespace Practice5.Task3
{
  public class Parrot : Animal, IFlyable
  {
    public Parrot(string name, int age)
      :base(name, age)
    {
      Console.WriteLine("An object of the 'Parrot' class was created");
    }

    public void Fly()
    {
      Console.WriteLine("Parrot is flying");
    }

    public override void MakeSound()
    {
      Console.WriteLine("Parrot is talking");
    }

    public void MakeSound(string words)
    {
      Console.WriteLine(words);
    }
  }
}
