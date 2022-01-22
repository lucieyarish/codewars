using System;
using System.Collections.Generic;

namespace CustomIgnore
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] input = new[]
            {
                "asd.txt", 
                "superlongfilename.java", 
                "definietlynotavirus.exe"
            }; //returns "superlongfilename.java"

            foreach (var VARIABLE in GetUnignoredFiles(input))
            {
                Console.WriteLine(VARIABLE);
            }
        }

        public static List<string> GetUnignoredFiles(string[] arr)
        {
            List<string> unignoredFiles = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!arr[i].Contains(".txt") && !arr[i].Contains(".exe"))
                {
                    unignoredFiles.Add(arr[i]);
                }
            }
            return unignoredFiles;
        }
    }
}