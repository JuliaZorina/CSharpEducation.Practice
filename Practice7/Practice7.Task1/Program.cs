using System;
using System.Collections.Generic;

namespace Practice7.Task1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      try
      {
        var storageInfo = new ListStorage<string>();
        storageInfo.Add("Item1");
        storageInfo.Add("Item2");
        storageInfo.Add("Item3");
        Console.WriteLine($"Метод Get:{storageInfo.Get(2)}");
        Console.WriteLine($"Count:{storageInfo.Count}");
      }
      catch(Exception ex) 
      { 
        Console.WriteLine(ex.ToString());
      }

    }
  }
}
