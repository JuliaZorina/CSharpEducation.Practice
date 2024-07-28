using System;

namespace Practice2.Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new string[10];
            Console.WriteLine("Введите строки для заполнения массива");
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();
            }
            Console.WriteLine("Полученный массив строк:");
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
