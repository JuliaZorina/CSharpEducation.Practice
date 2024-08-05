using System;

namespace Practice2.Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение первого числа, которое вы хотите сравнить");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение второго числа, которое вы хотите сравнить");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите оператор сравнения:\n > - больше, \n < - меньше, \n = - равно, \n != - не равно");
            var oper = Console.ReadLine();

            switch (oper)
            {
                case ">":
                    
                        Console.WriteLine(a > b);
                        break; 
                case "<":
                    Console.WriteLine(a < b);
                    break;
                case "=":
                    Console.WriteLine(a == b);
                    break;
                case "!=":
                    Console.WriteLine(a != b);
                    break;

            }
        }
    }
}
