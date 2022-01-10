using System;
using System.Collections.Generic;

namespace NumbersUnion
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = new[] {1, 2, 3};
            int[] input2 = new[] {2, 3, 4};
            //GetNumUnion(input1, input2); returns [1, 2, 3, 4];

            foreach (var VARIABLE in GetNumUnion(input1, input2))
            {
                Console.WriteLine(VARIABLE);
            }
        }

        public static List<int> GetNumUnion(int[] arr1, int[] arr2)
        {
            List<int> resultNums = new List<int>();
            if (arr1.Length == 0 && arr2.Length == 0)
            {
               return new List<int>() { 0 };
            }
            
            for (int i = 0; i < arr1.Length; i++)
            {
                
                resultNums.Add(arr1[i]);
            }

            for (int j = 0; j < arr2.Length; j++)
            {
                if (!resultNums.Contains(arr2[j]))
                {
                    resultNums.Add(arr2[j]);
                }
            }

            return resultNums;
        }
    }
}