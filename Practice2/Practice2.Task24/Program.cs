using System;

namespace Practice2.Task24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowWeekDay(WeekDay.Понедельник);
            ShowWeekDay(WeekDay.Вторник);
            ShowWeekDay(WeekDay.Среда);
            ShowWeekDay(WeekDay.Четверг);
            ShowWeekDay(WeekDay.Пятница);
            ShowWeekDay(WeekDay.Суббота);
            ShowWeekDay(WeekDay.Воскресенье);
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
        private static void ShowWeekDay(WeekDay day)
        {
            Console.WriteLine(day);
        }

    }
}
