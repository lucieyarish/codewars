using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Channels;
using Microsoft.VisualBasic;

namespace MakeTheDeadFishSwim
{
    class Program
    {
        static void Main(string[] args)
        {
            // i = ++, d = --, s = n*n, o = output the value into the return arr
            string myString = "iiisdoso"; //returns new int[] { 8, 64};

            int[] resultArr = Parse(myString);
            foreach (var VARIABLE in resultArr)
            {
                Console.WriteLine(VARIABLE);
            }
        }

        static int[] Parse(string input)
        {
            char[] letters = input.ToCharArray();
            int initVal = 0;
            List<int> outputNums = new List<int>();

            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] == 'i')
                {
                    initVal++;
                } 
                else if (letters[i] == 'd')
                {
                    initVal--;
                }
                else if (letters[i] == 's')
                {
                    initVal *= initVal;
                }
                else if (letters[i] == 'o')
                {
                    outputNums.Add(initVal);
                }
            }

            return outputNums.ToArray();
        }
    }
}