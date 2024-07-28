using System;

namespace Practice2.Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rows = 2;
            var cols = 3;
            CreateArray(rows, cols);
        }

        private static void CreateArray(int rows, int cols)
        {
            int[,] array = new int[rows, cols];
            var randomInt = new Random();   

            for(int i=0; i<rows; i++)
            {
                for(int j=0; j<cols; j++)
                {
                    array[i,j] = randomInt.Next();
                }
            }
            WriteArray(array);
        }

        private static void WriteArray(int[,] array)
        {
            Console.WriteLine("Полученный двумерный массив: ");
            for(int i=0; i<array.GetLength(0); i++)
            {
                //Console.WriteLine("----------------");
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
