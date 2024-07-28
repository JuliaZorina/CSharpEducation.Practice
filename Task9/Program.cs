using System;

namespace Practice2.Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var length = 10;
            CreateArray(length);
        }

        private static void CreateArray(int length)
        {
            int[] array = new int[length];
            var randomInt = new Random();
            for(int i =0; i<array.Length; i++)
            {
                array[i] = randomInt.Next();
            }
            WriteArray(array);
        }

        private static void WriteArray(int[] array)
        {
            Console.WriteLine("Полученный массив: \n");
            for(int i=0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}
