using System;

namespace Practice8.Task5
{
  public class TickHandler
  {
    public void Message(object sender, EventArgs e) 
    {
      var rnd = new Random();
      Console.WriteLine($"Случайное число от 1 до 100: {rnd.Next(1, 100)}");
    }

    public void TickNumber(object sender, EventArgs e)
    {
      Console.WriteLine("Тик: " + DateTime.Now.ToString("HH:mm:ss"));
    }
  }
}
