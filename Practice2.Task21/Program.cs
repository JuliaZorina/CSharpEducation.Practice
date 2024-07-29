using System;

namespace Practice2.Task21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GuessNumbergame();

        }

        private static void GuessNumbergame()
        {
            var rnd = new Random();
            Console.WriteLine("Игра 'Угадай число'. Введите число от 1 до 100");
            var userNumber = int.Parse(Console.ReadLine());
            if (userNumber == rnd.Next(1, 100))
            {
                Console.WriteLine("Поздравляем! Вы угадали число!");
            }
            else
            {
                Console.WriteLine("К сожалению, в этот раз вы не угадали число:(");
            }
        }
    }
}
