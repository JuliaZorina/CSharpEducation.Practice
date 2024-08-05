using System;

namespace Practice3.Task7
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(GetMonthDays(Month.May));
    }

    public enum Month
    {
      January,
      February,
      March,
      April,
      May,
      June,
      July,
      August,
      September,
      October,
      November,
      December
    }

    public static int GetMonthDays(Month month)
    {
      int days = 0;

      switch (month)
      {
        case Month.January: 
          days = 31;
          break;
        case Month.February: 
          days =  28;
          break;
        case Month.March:
          days =  30;
          break;
        case Month.April:
          days =  30;
          break;
        case Month.May:
          days =  31;
          break;
        case Month.June:
          days =  30;
          break;
        case Month.July:
          days =  31;
          break;
        case Month.August:
          days =  31;
          break;
        case Month.September:
          days =  30;
          break;
        case Month.October:
          days =  31;
          break;
        case Month.November:
          days =  30;
          break;
        case Month.December:
          days =  31;
          break;
      }
      return days;
    }
  }
}
