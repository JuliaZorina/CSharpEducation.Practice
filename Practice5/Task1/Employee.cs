using System;
using Practice5.Task2;

namespace Practice5.Task1
{
  public class Employee
  {
    private string name;
    public string Name
    {
      get { return name; }
      set
      {
        if (string.IsNullOrEmpty(value))
          throw new ArgumentNullException("Имя не может быть пустой строкой!");
        else
          this.name = value;
      }
    }
    private double salary;
    public double Salary
    {
      get { return salary; }
      set 
      {
        if (value < 0)
        {
          throw new ArgumentException("Зарплата не может быть меньше 0!");
        }
        else
          this.salary = value; 
      }
    }

    public Employee(string name, double salary)
    {
      this.Name = name;
      this.Salary = salary;
    }

    public virtual double CalculateBonus()
    {
      var message = "Метод CalculateBonus() класса Employee";
      var consoleLog = new ConsoleLogger();
      consoleLog.Log(message, LogLevel.Trace);
      consoleLog.Log(message, LogLevel.Debug);
      consoleLog.Log(message, LogLevel.Info);
      consoleLog.Log(message, LogLevel.Warning);
      consoleLog.Log(message, LogLevel.Error);
      consoleLog.Log(message, LogLevel.Fatal);
      Console.WriteLine();

      return this.salary*0.1;
    }
  }
}
