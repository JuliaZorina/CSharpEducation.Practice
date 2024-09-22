using System;
using System.Collections.Generic;

namespace Practice7.Task4
{
  public class Numbers
  {
    public IEnumerable<int> GetEvenNumbers(int start, int end)
    {
      for (int i = start; i < end; i++)
      {
        if (i % 2 == 0)
        {
          yield return i;
        }
      }
    }
  }
}
