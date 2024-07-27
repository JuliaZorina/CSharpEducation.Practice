using System;

namespace Practice2.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskD();   
        }
        public static void TaskA()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void TaskB()
        {
            int i = 0;
            while ( i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        public static void TaskC()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 10);
        }
        public static void TaskD()
        {
            Console.WriteLine("Введите слова");
            string[] wordsArr = new string[5];
            for (int i = 0; i < wordsArr.Length; i++)
            {
                wordsArr[i] = Console.ReadLine();
            }
            for(int i=0;i< wordsArr.Length; i++)
            {
                Console.Write($"{wordsArr[i]} ");
            }
        }
    }
}
