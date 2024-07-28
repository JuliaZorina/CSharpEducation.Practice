using System;

namespace Practice2.Task17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 4;
            var b = 12;
            ReplaceNumbers(ref a, ref b);
            Console.WriteLine($"{a}, {b}");
        }
        private static void ReplaceNumbers(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
