using System;

namespace Practice2.Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MakeCapitalLetter();
        }

        public static void ToHigherRegister()
        {
            Console.WriteLine("Введите строку для перевода в верхний регистр");
            var str = Console.ReadLine();
            Console.WriteLine($"Преобразованная строка: {str.ToUpper()}");
        }
        public static void ToLowerRegister()
        {
            Console.WriteLine("Введите строку для перевода в нижний регистр");
            var str = Console.ReadLine();
            Console.WriteLine($"Преобразованная строка: {str.ToLower()}");
        }
        public static void MakeCapitalLetter()
        {
            Console.WriteLine("Введите слово");
            var str = Console.ReadLine();
            var letters = str.ToCharArray();
            for(int i=0;i<letters.Length;i++)
            {
                if (i == 0)
                {
                    letters[0] = char.ToUpper(letters[0]);
                }
                else
                {
                    letters[i] = char.ToLower(letters[i]);
                }
                
            }
            Console.WriteLine($"Преобразованное слово: {new string(letters)}");
        }
    }
}
