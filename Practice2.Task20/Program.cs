using System;

namespace Practice2.Task20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new int[2,5];
            var rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(1, 100);
                    Console.Write($"{array[i,j]} ");
                }
                Console.WriteLine();    
            }

            MaxMinDifference(array);
        }
        private static void MaxMinDifference(int[,] array)
        {
            var maxValues = new int[] {-1, -1};
            var minValues = new int[] { 101, 101 };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j=0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > maxValues[i])
                    {
                        maxValues[i] = array[i, j];
                    }
                    if (array[i, j] < minValues[i])
                    {
                        minValues[i] = array[i, j];
                    }
                }
            }
            for(int i= 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine($"Разница максимального и минимального значений для {i}-й строки массива:" +
                    $" {maxValues[i] - minValues[i]}");
            }
        }
    }
}
