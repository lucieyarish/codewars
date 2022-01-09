using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace StringEndsWith
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "awesome study day day"; //returns 2 because two words end with 'y' and second occurrence of a word doesn't count
            string myString2 = "awesome study day yay"; //returns 3 because three words end with 'y' and all words are unique
            char myChar = 'y';

            Console.WriteLine(EndsWith(myString2, myChar));
        }

        public static int EndsWith(string inputString, char inputChar)
        {
            string[] stringArr = inputString.Split(' ');
            List<string> stringList = new List<string>();
            foreach (var VARIABLE in stringArr)
            {
                if (!stringList.Contains(VARIABLE))
                {
                    stringList.Add(VARIABLE);
                }
            }

            int count = 0;

            for (int i = 0; i < stringList.Count; i++)
            {
                if (stringList[i].EndsWith(inputChar))
                {
                    count++;
                }
            }

            return count;
        }
    }
}