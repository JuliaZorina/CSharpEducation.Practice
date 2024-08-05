using System;

namespace Practice2.Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawTriangleMySymbol();
        }
        public static void DrawTriangle()
        {
            Console.WriteLine("Введите высоту треугольника");
            var height = int.Parse(Console.ReadLine()); 
            for(int i= 1; i <= height; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();    
            }
        }
        public static void DrawReverseTriangle()
        {
            Console.WriteLine("Введите высоту треугольника");
            var height = int.Parse(Console.ReadLine());
            for (int i = 1; i <= height; i++)
            {
                int j;
                for(j = 0; j < height-i; j++)//выводит количество пробелов для корректного отступа
                {
                        Console.Write(" ");
                }
                for(int k=j; k < height; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                    
            }
        }
        public static void DrawTriangleMySymbol()
        {
            Console.WriteLine("Введите высоту треугольника");
            var height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите символ для отрисовки треугольника");
            var symbol = Console.ReadLine();    
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
