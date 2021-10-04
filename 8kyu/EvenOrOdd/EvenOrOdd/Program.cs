using System;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EvenOrOdd(2));
            Console.WriteLine(EvenOrOdd(1));
            Console.WriteLine(EvenOrOdd(0));
            Console.WriteLine(EvenOrOdd(7));
            Console.WriteLine(EvenOrOdd(-1));
        }

        public static string EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
    }
}