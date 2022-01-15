using System;
using System.Linq;

namespace TextExchangeAlgo
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "The class starts in 3 HR or so."; //returns "The class starts in 60 MIN or so."
            Console.WriteLine(GetTextExchange(input));
            
        }

        public static string GetTextExchange(string myString)
        {
            char[] s = myString.Where(Char.IsDigit).ToArray();
            int myInt = Int32.Parse(s);
            return $"The class starts in {myInt * 60} MIN or so.";
        }
        
        // static string GetTextExchange(string myString)
        // {
        //     string substr = myString.Substring(19, 2);
        //     int myNum = Int32.Parse(substr);
        //     return $"The class starts in {myNum * 60} MIN or so.";
        // }
    }
}