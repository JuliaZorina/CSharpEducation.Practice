using System;

namespace Practice2.Task22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GuessNumberGameTips();
        }

        private static void GuessNumberGame()
        {
            var rnd = new Random();
            var k = 10;
            var rndNumber = rnd.Next(1, 100);
            Console.WriteLine("Игра 'Угадай число'. Введите число от 1 до 100");
            int userNumber;
            for (int i=k; i > 0; i--)
            {
                userNumber = int.Parse(Console.ReadLine());
                if (userNumber == rndNumber)
                {
                    Console.WriteLine("Поздравляем! Вы угадали число");
                    break;
                }
                else if(i-1!=0)
                {
                    Console.WriteLine($"В этот раз вы не угадали число. Количество оставшихся попыток: {i-1}");
                }
                else
                {
                    Console.WriteLine("Количество доступных попыток закончлось. Вы проиграли :(");
                }
            }
        }

        private static void GuessNumberGameTips()
        {
            var rnd = new Random();
            var k = 10;
            var rndNumber = rnd.Next(1, 100);
            Console.WriteLine("Игра 'Угадай число'. Введите число от 1 до 100");
            int userNumber;
            for (int i = k; i > 0; i--)
            {
                userNumber = int.Parse(Console.ReadLine());
                if (userNumber == rndNumber)
                {
                    Console.WriteLine("Поздравляем! Вы угадали число");
                    break;
                }
                else if (i - 1 != 0)
                {
                    Console.WriteLine($"В этот раз вы не угадали число. Количество оставшихся попыток: {i - 1}");
                    if (userNumber > rndNumber)
                    {
                        Console.WriteLine($"Подсказка: число {userNumber} больше загаданного числа");
                    }
                    if (userNumber < rndNumber)
                    {
                        Console.WriteLine($"Подсказка: число {userNumber} меньше загаданного числа");
                    }
                }
                else
                {
                    Console.WriteLine("Количество доступных попыток закончлось. Вы проиграли :(");
                }
            }
        }
    }
}
