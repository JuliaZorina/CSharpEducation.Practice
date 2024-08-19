using System;
using Practice5.Task2;

namespace Practice5.Task1
{
  public class Manager: Employee
  {
    private int teamSize;
    public int TeamSize
    {
      get { return teamSize; }
      set
      {
        if (value < 0)
          throw new ArgumentException("Размер команды не может быть равным 0!");
        else
          this.teamSize = value;
      }
    }
    public Manager(string name, double salary, int teamSize) 
      : base(name, salary)
    {
      this.TeamSize = teamSize;
    }

    public override double CalculateBonus()
    {
      double bonus;

      var message = "Метод CalculateBonus() класса Manager";
      var consoleLog = new ConsoleLogger();
      consoleLog.Log(message, LogLevel.Trace);
      consoleLog.Log(message, LogLevel.Debug);
      consoleLog.Log(message, LogLevel.Info);
      consoleLog.Log(message, LogLevel.Warning);
      consoleLog.Log(message, LogLevel.Error);
      consoleLog.Log(message, LogLevel.Fatal);
      Console.WriteLine();

      if (this.TeamSize > 5)
        bonus = this.Salary * 0.25;
      else
        bonus = this.Salary * 0.2;
      return bonus;
    }
  }
}
