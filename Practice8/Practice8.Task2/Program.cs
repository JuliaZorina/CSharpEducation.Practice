using System;
using System.Collections.Generic;

namespace Practice8.Task2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<string> strings = new List<string> { "Пупа", "Лупа", "Бобер", "Длинная строка", "Anything", "Better", "аааааа"};
      var filters = new StringFilters();

      Predicate<string> predicate = filters.LongerThanFive;
      var filteredStr = strings.FindAll(predicate);
      foreach (string s in filteredStr)
      {
        Console.WriteLine(s);
      }
      Console.WriteLine();
      
      predicate = filters.StartsWithA;
      filteredStr = strings.FindAll(predicate);
      foreach (string s in filteredStr)
      {
        Console.WriteLine(s);
      }
      Console.WriteLine();
      
      predicate = filters.EndsWithA;
      filteredStr = strings.FindAll(predicate);
      foreach (string s in filteredStr)
      {
        Console.WriteLine(s);
      }
      Console.WriteLine();


    }
  }
}
