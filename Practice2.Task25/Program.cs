using System;

namespace Practice2.Task25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowWeekDay();
        }
        public enum WeekDay
        {
            Понедельник,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        private static void ShowWeekDay()
        {
            Console.WriteLine("Введите номер дня недели (число от 1 до 7)");
            var dayNumber = int.Parse(Console.ReadLine());

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine($"День недели под номером {dayNumber}: {WeekDay.Понедельник}");
                    break;
                case 2:
                    Console.WriteLine($"День недели под номером {dayNumber}: {WeekDay.Вторник}");
                    break;
                case 3:
                    Console.WriteLine($"День недели под номером {dayNumber}: {WeekDay.Среда}");
                    break;
                case 4:
                    Console.WriteLine($"День недели под номером {dayNumber}: {WeekDay.Четверг}");
                    break;
                case 5:
                    Console.WriteLine($"День недели под номером {dayNumber}: {WeekDay.Пятница}");
                    break;
                case 6:
                    Console.WriteLine($"День недели под номером {dayNumber}: {WeekDay.Суббота}");
                    break;
                case 7:
                    Console.WriteLine($"День недели под номером {dayNumber}: {WeekDay.Воскресенье}");
                    break;
                    default:
                    throw new ArgumentOutOfRangeException($"Дня недели под номером {dayNumber} не существует");

            }
        }
    }
}
