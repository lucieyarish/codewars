using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new[] {1, 2, 3};
            int[] input2 = new[] {3, 4, 5};
            int[] input3 = new[] {6, 7, 8};
            // returns 21

            Console.WriteLine(MaxPerimeter(input, input2, input3));
        }

        static int MaxPerimeter(int[] ints1, int[] ints2, int[] ints3)
        {
            int perimeter1 = 0;
            int perimeter2 = 0;
            int perimeter3 = 0;
            List<int> allPerimeters = new List<int>();

            for (int i = 0; i < ints1.Length; i++)
            {
                perimeter1 += ints1[i];
            }
            allPerimeters.Add(perimeter1);
            
            for (int i = 0; i < ints2.Length; i++)
            {
                perimeter2 += ints2[i];
            }
            allPerimeters.Add(perimeter2);
            
            for (int i = 0; i < ints3.Length; i++)
            {
                perimeter3 += ints3[i];
            }
            allPerimeters.Add(perimeter3);
            
            //returns the largest perimeter
            return allPerimeters.OrderByDescending(x => x).FirstOrDefault();
            
            //returns second largest perimeter
            //return allPerimeters.OrderByDescending(x => x).Skip(1).FirstOrDefault();
        }
    }
}