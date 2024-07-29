using System;

namespace Practice2.Task23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер года");
            var year = int.Parse(Console.ReadLine());
            if (year % 400 == 0)
            {
                Console.WriteLine($"{year} - високосный");
            }
            else if(year % 100 == 0)
            {
                Console.WriteLine($"{year} - невисокосный");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine($"{year} - високосный");
            }
            else
            {
                Console.WriteLine($"{year} - невисокосный");
            }
        }
    }
}
