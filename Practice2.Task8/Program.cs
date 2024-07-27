using System;

namespace Practice2.Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа");
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            if (a == b || b == c || a == c)
            {
                a = a+5;
                b = b+5;
                c = c+5; 

                Console.WriteLine($"{a }, {b }, {c }");
            }
            else
                Console.WriteLine("Равных нет");
        }
    }
}
