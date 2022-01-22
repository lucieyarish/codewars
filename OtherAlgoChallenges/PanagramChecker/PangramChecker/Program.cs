using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace PangramChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string pangram = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine(IsPangram(pangram));

        }

        static bool IsPangram(string p)
        {
            return p.ToLower().Where(ch => Char.IsLetter(ch)).GroupBy(ch => ch).Count() == 26;
            
            // char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            // List<char> individualChars = new List<char>();
            // foreach (var item in alphabet)
            // {
            //     individualChars.Add(item);
            // }
            //
            // char[] input = p.Replace(" ", "").ToCharArray();
            // foreach (var letter in input)
            // {
            //     if (!individualChars.Contains(letter))
            //     {
            //         return false;
            //     }
            // }
        }
    }
}