using System;

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
