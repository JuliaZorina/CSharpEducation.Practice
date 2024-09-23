using System;

namespace Practice7.Task2
{
  public class Person : ICloneable
  {
    public int Age { get; set; }
    public string Name { get; set; }

    public object Clone()
    {
      return new Person(this.Name, this.Age);
    }

    public Person(string name, int age)
    { 
      this.Name = name;
      this.Age = age; 
    }
  }
}
