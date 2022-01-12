using System;
using System.Collections.Generic;

namespace CommonNums
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = new[] {4, 5, 6, 7};
            int[] input2 = new[] {2, 3, 4, 5, 7, 9}; 
            //FindCommonNums(input1, input2) returns 4, 5, 7

            foreach (var VARIABLE in FindCommonNums(input1, input2))
            {
                Console.WriteLine(VARIABLE);
            }
        }

        public static List<int> FindCommonNums(int[] arr1, int[] arr2)
        {
            List<int> commonNumbers = new List<int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        commonNumbers.Add(arr1[i]);
                    }
                }
            }
            return commonNumbers;
        }
    }
}