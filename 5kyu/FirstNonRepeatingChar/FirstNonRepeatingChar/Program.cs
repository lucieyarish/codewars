using System;
using System.Collections.Generic;

namespace FirstNonRepeatingChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "stress"; //returns "t"
            string input2 = "sTreSS"; //returns "T"

            FirstNonRepeatingLetter(input1);
        }

        public static string FirstNonRepeatingLetter(string s)
        {
            char[] myCharArr = s.ToCharArray();

            Dictionary<int, char> letterDict = new Dictionary<int, char>();
            for (int i = 0; i < myCharArr.Length; i++)
            {
                letterDict.Add(i + 1, myCharArr[i]);
            }
            return s.Substring(0, 1);
        }
    }
}