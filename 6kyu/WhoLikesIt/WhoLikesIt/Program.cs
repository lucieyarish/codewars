using System;

namespace WhoLikesIt
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] emptyArr = new string[0]; //"no one likes this"
            string[] onePersonLikes = new[] {"Peter"}; // "Peter likes this"
            string[] twoPeopleLike = new[] {"Jacob", "Alex"}; //"Jacob and Alex like this"
            string[] threePeopleLike = new[] {"Max", "John", "Mark"}; // "Max, John and Mark like this"
            
            //For 4 or more names, the number in "and 2 others" simply increases
            string[] fourPeopleLike = new[] {"Alex", "Jacob", "Mark", "Max"}; //"Alex, Jacob and 2 others like this"

            Console.WriteLine(Likes(fourPeopleLike));
        }

        public static string Likes(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names.Length == 1)
                {
                    return $"{names[i]} likes this";
                }
                
                if(names.Length == 2)
                {
                    return $"{names[i]} and {names[i + 1]} like this";
                }

                if (names.Length == 3)
                {
                    return $"{names[i]}, {names[i + 1]} and {names[i + 2]} like this";
                }

                if (names.Length >= 4)
                {
                    return $"{names[i]}, {names[i + 1]} and {names.Length - 2} others like this";
                }
            }
            
            return "no one likes this";
        }
    }
}