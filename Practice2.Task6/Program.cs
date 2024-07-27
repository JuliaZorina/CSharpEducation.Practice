using System;

namespace Practice2.Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var counter = 0;
            for (int i = 0; i < args[0].Length; i++)
            {
                if (args[0][i] == args[1][0])
                    counter++;

            }
            Console.WriteLine((double)counter / args[0].Length * 100 + "%");
        }

        private static void SymbolInString()
        {
            var s = "банан";
            var symbol = 'а';
            var counter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == symbol)
                    counter++;

            }
            Console.WriteLine((double)counter / s.Length * 100 + "%");
        }
        private static void UserSymbolInString()
        {
            var s = Console.ReadLine();

            var symbol = Console.ReadLine()[0];
            var counter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == symbol)
                    counter++;

            }
            Console.WriteLine((double)counter / s.Length * 100 + "%");
        }

    }
}
