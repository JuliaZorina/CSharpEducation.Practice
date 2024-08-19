using System;
using System.Security.Authentication.ExtendedProtection.Configuration;

namespace Practice5.Task3
{
  public class Animal
  {
    private string name;
    public string Name
    {
      get { return this.name; }
      set
      {
        if (string.IsNullOrEmpty(value))
          throw new ArgumentException("Имя не может быть пустой строкой!");
        else
          this.name = value;
      }
    }

    private int age;
    public int Age
    {
      get { return this.age; }
      set
      {
        if (age<0)
          throw new ArgumentException("Возраст не может быть меньше 0!");
        else
          this.age = value;
      }
    }

    public Animal(string name, int age)
    {
      this.Name = name;
      this.Age = age;
    }

    public void Eat()
    {
      Console.WriteLine("Animal is eating");
    }

    public void Sleep()
    {
      Console.WriteLine("Animal is sleeping");
    }

    public virtual void MakeSound()
    {
      Console.WriteLine("Some generic animal sound");
    }
  }  
}
