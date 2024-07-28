using System;

namespace Practice2.Task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = -1;
            ChangeNumberSign(ref number);
            Console.WriteLine(number);
        }
        private static void ChangeNumberSign(ref int number)
        {
            number = -number;
        }
    }
}
