using System;

namespace Practice5.Task3
{
  public class Eagle : IFlyable
  {
    private string name;
    public string Name
    {
      get { return this.name; }
      set
      {
        if(string.IsNullOrEmpty(value))
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
        if(value<0)
          throw new ArgumentException("Возраст не может быть меньше 0!");
        else
          this.age = value;
      }
    }


    public Eagle(string name, int age)
    {
      this.Name = name;
      this.Age = age;
    }
    public void Fly()
    {
      Console.WriteLine("Eagle is soaring high");
    }
  }
}
