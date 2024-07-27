using System;

namespace Practice2.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение переменной a");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение переменной b");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение переменной f");
            var f = double.Parse(Console.ReadLine());
            if (a != 0)
            {
                Console.WriteLine($"Значение выражения равно: {(a + b - f / a) + f * a * a - (a + b)}");
            }
            else
            {
                Console.WriteLine("Введено некорректное значение переменной a. Значение должно быть !=0");
            }

        }
    }
}
