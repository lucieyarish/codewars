using System;
using System.Collections.Generic;
using System.Linq;

namespace SmallestDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new[] {3, 1, 56, 34, 55}; //returns 1 (diff between 55 and 56)
            Console.WriteLine(SmallestDiff(myArr));
        }

        static int SmallestDiff(int[] numbers)
        {
            var sortedCopy = numbers.OrderBy(i => i).ToList();
            int currentSmallestDiff = sortedCopy[1] - sortedCopy[0];
            for (int i = 2; i < sortedCopy.Count(); i++)
            {
                for (int j = i + 1; j < sortedCopy.Count(); j++)
                {
                    if (sortedCopy[j] - sortedCopy[i] < currentSmallestDiff || 
                        sortedCopy[j] - sortedCopy[i] == currentSmallestDiff)
                    {
                        currentSmallestDiff = sortedCopy[j] - sortedCopy[i];
                        return currentSmallestDiff;
                    }
                }
            }
            return currentSmallestDiff;
        }
    }
}