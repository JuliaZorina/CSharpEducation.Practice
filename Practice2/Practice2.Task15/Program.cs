using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new int[10];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            var invertedArray = InvertedArray(array);

            Console.WriteLine("Инвертированный массив: ");
            for(int i = 0; i < invertedArray.Length; i++)
            {
                Console.Write($"{invertedArray[i]} ");
            }
        }

        private static int[] InvertedArray(int[] array)
        {
            var invertedArray = new int[array.Length];
            for(int i=0; i < array.Length; i++)
            {
                invertedArray[invertedArray.Length-i-1] = array[i];
            }
            return invertedArray;
        }
    }
}
