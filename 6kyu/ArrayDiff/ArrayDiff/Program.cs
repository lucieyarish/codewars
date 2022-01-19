using System;
using System.Collections.Generic;

namespace ArrayDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = { 1, 2, 2, 2, 3 };
            int[] input2 = { 2 };
            int[] input3 = { 1, 2 };
            int[] input4 = { 1, 2 };
            //RemoveSameNums(input1, input2); //returns [1, 3]
            //RemoveSameNums(input1, input2); //returns [2]
            foreach (var VARIABLE in RemoveSameNums(input3, input4))
            {
                Console.WriteLine(VARIABLE);
            }
        }

        public static int[] RemoveSameNums(int[] arr1, int[] arr2)
        {
            List<int> diffNums = new List<int>();
            
            if (arr2.Length == 0)
            {
                return arr1;
            }
            
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] != arr2[j])
                    {
                        diffNums.Add(arr1[i]);
                    }
                }
            }

            return diffNums.ToArray();
        }
    }
}