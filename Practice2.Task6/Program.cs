using System;

namespace Practice2.Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "банан";
            var symbol = 'а';
            var counter = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == symbol)
                    counter++;

            }
            Console.WriteLine((double)counter/s.Length*100 + "%");
        }
    }
}
