using System;
using System.Collections.Generic;

namespace Practice8.Task2
{
  public class StringFilters
  {
    public bool LongerThanFive(string a)
    {
      if (a.Length > 5)
        return true;
      else
        return false;
    }
    
    public bool StartsWithA(string a)
    {
      if (a[0] == 'A'|| a[0] == 'А'|| a[0] == 'a' || a[0] == 'а')
        return true;
      else
        return false;
    }

    public bool EndsWithA(string a)
    {
      if (a[a.Length-1] == 'A' || a[a.Length - 1] == 'А' || a[a.Length - 1] == 'a' || a[a.Length - 1] == 'а')
        return true;
      else
        return false;
    }
  }
}
