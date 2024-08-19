using System;
using Practice5.Task2;

namespace Practice5.Task1
{
  public class Contractor : Employee
  {

    private int hourlyRate;
    public int HourlyRate
    {
      get { return hourlyRate; }
      set 
      {
        if (value < 0)
          throw new ArgumentException("Количество отработанных часов не может быть меньше 0!");
        else
          this.hourlyRate = value; 
      }
    }

    public Contractor(string name, double salary, int hourlyRate) : base(name, salary)
    {
      this.HourlyRate = hourlyRate;
    }

    public double CalculateBonus(int hoursWorked)
    {
      double bonus;
      var message = "Метод CalculateBonus() класса Contactor";
      var consoleLog = new ConsoleLogger();
      consoleLog.Log(message, LogLevel.Trace);
      consoleLog.Log(message, LogLevel.Debug);
      consoleLog.Log(message, LogLevel.Info);
      consoleLog.Log(message, LogLevel.Warning);
      consoleLog.Log(message, LogLevel.Error);
      consoleLog.Log(message, LogLevel.Fatal);
      Console.WriteLine();

      if (hoursWorked <= 20)
        bonus = this.Salary * 0.05;
      else if (hoursWorked <= 40)
        bonus = this.Salary * 0.15;
      else if (hoursWorked <= 60)
        bonus = this.Salary * 0.25;
      else
        bonus = this.Salary * 0.4;
      return bonus;
    }
  }
}
