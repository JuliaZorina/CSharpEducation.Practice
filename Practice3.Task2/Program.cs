using Practice3.Task1;
using System;

namespace Practice3.Task2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var student = new Student();

      Console.WriteLine("Введите имя студента");
      student.name = Console.ReadLine();

      Console.WriteLine("Введите возраст студента");
      student.age = int.Parse(Console.ReadLine());

      Console.WriteLine("Введите средний балл студента");
      student.AverageScore = double.Parse(Console.ReadLine());

      student.StudentInfo();
    }
  }
}
