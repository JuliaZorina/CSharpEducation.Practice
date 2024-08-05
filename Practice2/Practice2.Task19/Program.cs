using System;

namespace Practice2.Task19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new int[5];
            var rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 100);
                Console.WriteLine(array[i]);
            }

            MaxMinDifference(array);
        }

        private static void MaxMinDifference(int[] array)
        {
            var maxValue = -1;
            var minValue = 101;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }
            Console.WriteLine(maxValue - minValue);
        }
    }
}
