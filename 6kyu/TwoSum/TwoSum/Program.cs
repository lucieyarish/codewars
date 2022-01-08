using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new Tuple<int[], int>(new int[] {1, 2, 3}, 4); //returns (0, 2) - the indexes of numbers that give the target value when added
            var input2 = new Tuple<int[], int>(new int[] {2, 2, 3}, 4); //returns (0, 1)

            int[] input3 = new[] {1, 2, 3};
            int target = 4;

            foreach (var VARIABLE in GetTwoSumPositions(input3, target))
            {
                Console.WriteLine(VARIABLE);
            }
        }
        
        public static int[] GetTwoSumPositions(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[0];
        }
        
    }
}