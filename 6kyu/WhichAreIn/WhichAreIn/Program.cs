using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace WhichAreIn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = new[] { "arp", "live", "strong" };
            string[] arr2 = new[] { "lively", "alive", "harp", "sharp", "armstrong" };

            foreach (var VARIABLE in GetLexSort(arr1, arr2))
            {
                Console.WriteLine(VARIABLE);
            }
        }

        public static string[] GetLexSort(string[] input1, string[] input2)
        {
            List<string> substrings = new List<string>();
            for (int i = 0; i < input2.Length; i++)
            {
                for (int j = 0; j < input1.Length; j++)
                {
                    if (input2[i].Contains(input1[j]) && !substrings.Contains(input1[j]))
                    {
                        substrings.Add(input1[j]);
                    }
                }
            }
            
            substrings.Sort();
            
            return substrings.ToArray();
        }
    }
}