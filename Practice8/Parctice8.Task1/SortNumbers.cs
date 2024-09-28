using System;

namespace Parctice8.Task1
{
  public class SortNumbers
  {
    public int SortAscending(int x, int y)
    {
      return x.CompareTo(y);
    }

    public int SortDescending(int x, int y)
    {
      return y.CompareTo(x);
    }
  }
}
