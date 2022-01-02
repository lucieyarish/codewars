using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfDigits_DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 16; //returns 1 + 6 = 7
            int num2 = 942; //returns 9 + 4 + 2 = 15 --> 1 + 5 = 6
            int num3 = 132189; // returns 1 + 3 + 2 + 1 + 8 + 9 = 24 --> 2 + 4 = 6

            Console.WriteLine(DigitalRoot(num2));
        }

        static int DigitalRoot(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n % 9 == 0)
            {
                return 9;
            }

            return n % 9;
        }

        // public static int DigitalRoot(int n)
        // {
        //     char[] myCharArr = n.ToString().ToCharArray();
        //     List<int> allInts = new List<int>();
        //     foreach (var VARIABLE in myCharArr)
        //     {
        //         allInts.Add(int.Parse(VARIABLE.ToString()));
        //     }
        //     
        //     int sum1 = 0;
        //     int sum2 = 0;
        //     
        //     List<int> twoNumsList = new List<int>();
        //     
        //     
        //     for (int i = 0; i < allInts.Count; i++)
        //     {
        //         if (allInts.Count > 2)
        //         {
        //             sum1 += allInts[i];
        //             foreach (var number in allInts)
        //             {
        //                 sum2 += number;
        //             }
        //         }
        //         else
        //         {
        //             sum1 += allInts[i];
        //             return sum1;
        //         }
        //     }
        //return sum2;
    }
}