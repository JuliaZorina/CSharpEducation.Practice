using System;
namespace Practice3.Task9
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var student = new Student()
      {
        name = "Julia",
        age = 22
      };
      Console.WriteLine($"Имя: {student.name}, возраст: {student.age}");
      ChangeName(student);
      Console.WriteLine($"Имя: {student.name}, возраст: {student.age}");
    }

    public static void ChangeName(Student student)
    {
      student.name = "Аноним";
    }
  }
}
