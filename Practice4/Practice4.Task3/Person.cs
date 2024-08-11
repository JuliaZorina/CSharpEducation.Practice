using System;
namespace Practice4.Task3
{
    public class Person
    {
    private string name;

    public string Name
    {
      get 
      { 
        return name; 
      }
      set
      {
        if (string.IsNullOrEmpty(value))
          throw new ArgumentException("Не существует человека без имени");
        else
        {
          this.name = value;
        }
      }
    }

    private int age;

    public int Age
    {
      get
      {
        return age;
      }
      set
      {
        if (value <= 0)
          throw new ArgumentException("Возраст не может быть меньше 0!");
        else
        {
          this.age = value;
        }
      }
    }

    public Person(string name,int age)
    {
      Name = name;
      Age = age;
    }

    public void Print()
    {
      Console.WriteLine($"Имя: {name}.\nВозраст: {age}");
    }

    }
}
