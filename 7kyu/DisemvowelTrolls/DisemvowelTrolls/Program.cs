using System;
using System.Collections.Generic;

namespace DisemvowelTrolls
{
    class Program
    {
        static void Main(string[] args)
        {
            string comment1 = "This website is for losers LOL!";
            string comment2 = "No offense but,\nYour writing is among the worst I've ever read";
            string comment3 = "What are you, a communist?";
            List<char> charsToRemove = new List<char>()
            {
                'a', 'e', 'i', 'o', 'u'
            };
            
            Console.WriteLine(Disemvowel(comment1, charsToRemove));
        }

        public static string Disemvowel(string trollComment, List<char> charsToRemove)
        {
            foreach (char c in charsToRemove)
            {
                trollComment = trollComment.Replace(c.ToString(), String.Empty);
            }
            return trollComment;
        }
    }
}