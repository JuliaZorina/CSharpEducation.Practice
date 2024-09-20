using System;

namespace Practice6.Task3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      try
      {
        Console.WriteLine("Введите свое имя");
        var user = new User(Console.ReadLine());
        user.GetUserAge();
      }
      catch (ArgumentException ex)
      {
        Console.WriteLine(ex.ToString());
      }
      catch(TooManyAttemptsException ex)
      {
        Console.WriteLine(ex.ToString());
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
    }
  }
}
