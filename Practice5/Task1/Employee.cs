using System;

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
      return this.salary*0.1;
    }
  }
}
