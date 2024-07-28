using System;

namespace Practice2.Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new int[int.Parse(args[0])];
            var randomInt = new Random();
            for(int i=0; i < array.Length; i++)
            {
                array[i] = randomInt.Next();    
            }
            Console.WriteLine("Полученный массив:");
            for(int i=0; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
