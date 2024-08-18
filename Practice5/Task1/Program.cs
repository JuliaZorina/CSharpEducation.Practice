using System;

namespace Practice5.Task1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Employee employee = new Employee("Julia", 100);
      Manager manager = new Manager("Egor", 100, 15);
      Contractor contractor = new Contractor("Oleg", 100, 40);

      /*Console.WriteLine($"employee: {employee.CalculateBonus()}.\nmanager: {manager.CalculateBonus()}." +
        $"\ncontractor: {contractor.CalculateBonus()}.");*/

      PrintSomeData(employee);
      PrintSomeData(manager);
      PrintSomeData(contractor);
    }

    public static void PrintSomeData(Employee person)
    {
      if (person is Employee)
      {
        Console.WriteLine($"employee: {person.CalculateBonus()}.");
      }
      if (person is Manager)
      {
        var manager = person as Manager;
        Console.WriteLine($"manager: {manager.CalculateBonus()}.");
      }
      if (person is Contractor)
      {
        var contractor = person as Contractor;
        Console.WriteLine($"contractor: {contractor.CalculateBonus(contractor.HourlyRate)}.");
      }
      Console.WriteLine();
    }
  }
}
