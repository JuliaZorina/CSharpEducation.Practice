using System;

namespace Practice2.Task18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, -3, 4, -5, 6, 7, -8, -9};
            int number;
            array = DeleteNegativeNumbers(array, out number);
            Console.WriteLine(number);
        }

        private static int[] DeleteNegativeNumbers(int[] array, out int deletedNumbers)
        {
            deletedNumbers = 0; 
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < 0)
                {
                    array[i] = -array[i];
                    deletedNumbers++;
                }
            }
            return array;
        }
    }
}
