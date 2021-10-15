using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace AreTheyTheSame
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = { 121, 144, 19, 161, 19, 144, 19, 11 };
            double[] b = { 121, 14641, 20736, 361, 25921, 361, 20736, 361};

            Console.WriteLine(comp(a, b));
        }

        public static bool comp(double[] a, double[] b)
        {
            foreach (var number in b)
            {
                if (!a.Contains(Math.Sqrt(number)))
                { 
                    return false;
                }
            }
            return true;
        }
    }
}