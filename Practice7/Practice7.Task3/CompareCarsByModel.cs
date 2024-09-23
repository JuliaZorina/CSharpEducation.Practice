using System;
using System.Collections;

namespace Practice7.Task3
{
  public class CompareCarsByModel : IComparer
  {
    public int Compare(object x, object y)
    {
      if (x == null && y == null)
      {
        throw new ArgumentNullException();
      }
      else
      {
        if (x is Car car1 && y is Car car2)
        {
          return car1.Model.Length - car2.Model.Length;
        }
        else
        {
          throw new ArgumentException();
        }
      }
    }
  }
}
