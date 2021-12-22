using System;
using System.Collections.Generic;
using System.Text;

namespace ReplaceWithAlphabetPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Replace every letter with its position in the alphabet
            //If anything isn't a letter, ignore it and don't return it
            
            string wordToConvert = "hey"; //returns "8 5 25" as a string
            string anotherWord = "Hello there!"; // returns "8 5 12 12 15 20 8 5 18 5"

            Console.WriteLine(ReplaceWithPositionInAlphabet(wordToConvert));
        }

        static string ReplaceWithPositionInAlphabet(string wordToReplace)
        {
            Dictionary<int, char> alphabet = new Dictionary<int, char>
            {
                {1, 'a'}, {2, 'b'}, {3, 'c'}, {4, 'd'}, 
                {5, 'e'}, {6, 'f'}, {7, 'g'}, {8, 'h'}, 
                {9, 'i'}, {10, 'j'}, {11, 'k'}, {12, 'l'},
                {13, 'm'}, {14, 'n'}, {15, 'o'}, {16, 'p'},
                {17, 'q'}, {18, 'r'}, {19, 's'}, {20, 't'},
                {21, 'u'}, {22, 'v'}, {23, 'w'}, {24, 'x'},
                {25, 'y'}, {26, 'z'}
            };

            List<int> convertedInts = new List<int>();

            foreach (var letter in wordToReplace.ToLower())
            {
                if (alphabet.ContainsValue(letter))
                {
                    foreach (var keyVar in alphabet.Keys)
                    {
                        if (alphabet[keyVar] == letter)
                        {
                            convertedInts.Add(keyVar);
                        }
                    }
                }
            }

            StringBuilder sb = new StringBuilder();

            foreach (var item in convertedInts)
            {
                sb.Append(item + " ");
            }

            return sb.ToString().Trim();
        }
    }
}