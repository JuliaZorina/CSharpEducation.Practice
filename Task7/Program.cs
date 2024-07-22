using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0;//1 катет
            double b = 5;//2 катет
            double c = 30;//гипотенуза

            if (c == 0 && a > 0 && b > 0)
            {
                Console.WriteLine("Известны два катета. Длина гипотенузы = " + Math.Sqrt(a * a + b * b));
            }
            else if (b == 0 && a > 0 && c > 0)
            {
                Console.WriteLine("Известны катет и гипотенуза. Длина второго катета = " + Math.Sqrt(c * c - a * a));
            }
            else if (a == 0 && b > 0 && c > 0)
            {
                Console.WriteLine("Известны катет и гипотенуза. Длина второго катета = " + Math.Sqrt(c * c - b * b));
            }
        }
    }
}
