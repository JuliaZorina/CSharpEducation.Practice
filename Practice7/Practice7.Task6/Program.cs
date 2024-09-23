using System;

namespace Practice7.Task6
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var str = Console.ReadLine();
      Console.WriteLine(str.IsPalindrome());
      Console.WriteLine(str.ToTitleCase());
    }
  }
}
