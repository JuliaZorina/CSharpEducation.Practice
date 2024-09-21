using System;
using System.Collections;

namespace Practice7.Task3
{
  public class Car : IComparer
  {
    public string Make {  get; set; }
    public string Model { get; set; }

    public int Compare(object x, object y)
    {
      if(x == null && y == null)
      {
        throw new ArgumentNullException(nameof(x));
      }
      else
      {
        if (x is Car car1 && y is Car car2) 
        {
          if (car1.Model.Length != car2.Model.Length)
          {
            return car1.Model.Length - car2.Model.Length;
          }
          else if(car1.Make.Length != car2.Make.Length)
          {
            return car1.Make.Length - car2.Make.Length;
          }
          else
          {
            return car1.GetHashCode() - car2.GetHashCode();
          }
        }
        else
        {
          throw new ArgumentException("Не все элементы имеют нужный для сравнения тип");
        }
      }       
    }
    public override int GetHashCode()
    {
      return this.Model.Length*this.Make.Length*1027;
    }
  }
  
}
