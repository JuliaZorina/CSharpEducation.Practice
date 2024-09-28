using System;
using System.Threading;
using Timer = Practice8.Task5.Timer;

namespace Practice8.Task5
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Timer timer = new Timer(2000); 
      TickHandler tickHandler = new TickHandler();
      timer.Tick += tickHandler.TickNumber; 
      timer.Tick += tickHandler.Message; 

      timer.Start();

      Console.WriteLine("Таймер запущен. Нажмите любую клавишу для остановки.");
      Console.ReadKey();

      timer.Stop();
      Console.WriteLine("Таймер остановлен.");
    }
  }
}
