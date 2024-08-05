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
            var str = "банан";
            var symbol = 'а';
            var counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == symbol)
                    counter++;

            }
            Console.WriteLine((double)counter / str.Length * 100 + "%");
        }
        private static void UserSymbolInString()
        {
            var str = Console.ReadLine();

            var symbol = Console.ReadLine()[0];
            var counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == symbol)
                    counter++;

            }
            Console.WriteLine((double)counter / str.Length * 100 + "%");
        }

    }
}
