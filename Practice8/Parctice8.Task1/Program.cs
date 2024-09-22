using System;
using System.Collections.Generic;

namespace Parctice8.Task1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var sort = new SortNumbers();
      
      int[] numbers = new int[] { 3, 5, 9, 2, 1, 0 };

      Console.WriteLine($"Выберите способ сортировки:\nНажмите 1 для сортировки по возрастанию" +
        $"\nНажмите 2 для сортировки по убыванию\n");
      var res = int.Parse(Console.ReadLine());
      switch (res)
      {
        case 1:
          Array.Sort(numbers, sort.SortAscending);
          foreach (int x in numbers)
            Console.WriteLine(x);
          break;
        case 2:
          Array.Sort(numbers, sort.SortDescending);
          foreach (int x in numbers)
            Console.WriteLine(x);
          break;
      }     

    }
  }
}
