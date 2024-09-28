using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice8.Task4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<string> strings = new List<string> { "Пупа", "Лупа", "Бобер", "Длинная строка", "Anything", "Better", "аааааа" };

      Func<string, string> toUpper = s => s.ToUpper();
      Func<string, string> reverse = s => new string(s.Reverse().ToArray());
      Func<string, string> makeACapital = MakeLetterACapital;
      Func<string, string> makeStairs = MakeStairs;

      List<string> list = new List<string>(); 
      
      Console.WriteLine($"Выберите способ сортировки:\nНажмите 1 для перевода строк в верхний регистр" +
        $"\nНажмите 2 для получения слов наоборот"+
        $"\nНажмите 3 для получения слов лесенкой"+
        $"\nНажмите 4 для получения слов, в которых буква а переведена в верхний регистр\n");
      var res = int.Parse(Console.ReadLine());
      switch (res)
      {
        case 1:
          list = strings.Select(toUpper).ToList();
          break;
        case 2:
          list = strings.Select(reverse).ToList();
          break;
        case 3:
          list = strings.Select(makeStairs).ToList();
          break;
        case 4:
          list = strings.Select(makeACapital).ToList();
          break;
      }
      foreach (string s in list)
      {
        Console.WriteLine(s);
      }
    }

    public static string MakeLetterACapital(string s)
    {
      var strArray = s.ToCharArray();
      for(int i=0; i<s.Length;i++)
      {
        if (strArray[i] == 'a' || strArray[i] == 'A' || strArray[i] == 'А' || strArray[i] == 'а')
        {
          strArray[i] = strArray[i].ToString().ToUpper().ToCharArray()[0];
        }
      }
      return string.Join("",strArray);
    }

    public static string MakeStairs(string s)
    {
      var strArray = s.ToCharArray();
      for(int i=0; i<s.Length;i++)
      {
        if (i%2==0)
        {
          strArray[i] = strArray[i].ToString().ToUpper().ToCharArray()[0];
        }
      }
      return string.Join("",strArray);
    }
  }
}
