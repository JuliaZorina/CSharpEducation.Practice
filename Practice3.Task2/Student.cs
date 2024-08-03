using System;

namespace Practice3.Task1
{
  class Student
  {
    public string name;
    public int age;
    private double averageScore;

    public double AverageScore
    {
      get
      {
        return averageScore;
      }
      set
      {
        if(value<=0 || value >= 5)
        {
          Console.WriteLine("Средний балл не может быть меньше 0 или больше 5");
        }
        else
        {
          averageScore = value;
        }
      }
    }

    public void StudentInfo()
    {
      Console.WriteLine($"Имя: {name}.\nВозраст: {age}.\nСредний балл: {averageScore} ");
    }
  }
}
