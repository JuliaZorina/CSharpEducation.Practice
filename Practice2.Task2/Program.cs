using System;

namespace Practice2.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CToF();
        }
        public static void MToKm()
        {
            Console.WriteLine("Введите длину в метрах");
            var m = double.Parse(Console.ReadLine());
            Console.WriteLine($"Длина в километрах: {m*0.001}");
        }
        public static void KmTocm()
        {
            Console.WriteLine("Введите длину в километрах");
            var km = double.Parse(Console.ReadLine());
            Console.WriteLine($"Длина в сантиметрах: {km * 100000}");
        }
        public static void MsToKmH()
        {
            Console.WriteLine("Введите скорость в м/с");
            var ms = double.Parse(Console.ReadLine());
            Console.WriteLine($"Скорость в км/ч: {ms * 3.6}");
        }
        public static void CToF()
        {
            Console.WriteLine("Введите температуру в градусах Цельсия");
            var c = double.Parse(Console.ReadLine());
            Console.WriteLine($"Температура в Фаренгейтах: {c * 1.8+32}");
        }
    }
}
