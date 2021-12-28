using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstNonRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "aaabcccdeeef"; //returns 'b'
            string input2 = "eeefffsshddd"; //returns 'h'
            string input3 = "aahhbbjjkll"; //returns 'k'

            Console.WriteLine(GetFirstNonRepeatingChar(input3));
        }

        static char GetFirstNonRepeatingChar(string s)
        {
            return s.GroupBy(x => x).FirstOrDefault(l => l.Count() == 1).Key;

        }

        /* RETURNS THE LAST CHAR UNIQUE IN THE SEQUENCE */
        // static char GetFirstNonRepeatingChar(string s)
        // {
        //     char[] myArr = s.ToLower().ToCharArray();
        //     char uniqueChar = ' ';
        //     for (int i = 0; i < myArr.Length; i++)
        //     {
        //         for (int j = + 1; j < myArr.Length; j++)
        //         {
        //             if (myArr[j] != myArr[i])
        //             {
        //                 uniqueChar = myArr[j];
        //             }
        //         }
        //     }
        //
        //     return uniqueChar;
        // }

        // static char GetFirstNonRepeatingChar(string s)
        // {
        //     char[] myChars = s.ToLower().ToCharArray();
        //     char nonRepeatingChar = s[0];
        //     for (int i = 0; i < myChars.Length; i++)
        //     {
        //         for (int j = i + 1; j < myChars.Length; j++)
        //         {
        //             if (myChars[j] == nonRepeatingChar && myChars[j] == myChars[j] + 1)
        //             {
        //                 return myChars[j];
        //             }
        //            
        //         }
        //     }
        //     return '?';
        // }
    }
}