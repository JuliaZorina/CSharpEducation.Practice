using System;

namespace Practice2.Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = CreateArray(10);
            var rnd = new Random();
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next();   
            }

            for(int i=0; i<array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        private static int[] CreateArray(int n)
        {
            return new int[n];
        }
    }
}
