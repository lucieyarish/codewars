using System;
using System.Collections.Generic;
using System.Linq;

namespace NiceArray
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr1 = new[] {2, 10, 9, 3};
            //2 = 3 - 1;
            //10 = 9 + 1;
            //9 = 10 - 1;
            //3 = 2 + 1;
            int[] arr2 = new[] { 3, 4, 5, 7};
            int[] arr3 = new[] {1, 2, 3};

            Console.WriteLine(IsNice(arr1));
        }

        public static bool IsNice(int[] array)
        {
            if (array.Length == 0)
            {
                return false;
            }
            foreach (var number in array)
            {
                if (array.Contains(number - 1) || array.Contains(number + 1))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}