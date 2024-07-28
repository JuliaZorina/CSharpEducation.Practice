using System;

namespace Practice2.Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new int[int.Parse(args[0])];
            int i = 0;
            while (i < array.Length)
            {
                array[i] = int.Parse(args[1]);
                i++;
            }
            i = 0;
            Console.WriteLine("Полученный массив:");
            do
            {
                Console.WriteLine(array[i]);
                i++;
            }
            while (i < array.Length);
        }
    }
}
