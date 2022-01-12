using System;

namespace WaveSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new[] {4, 1, 7, 5, 6, 2, 3}; //sorted
            int[] input2 = new[] {1, 4, 5, 3}; // returns 4, 1, 5, 3
        }

        public static int[] WaveSort(int[] arr)
        {
            int temp = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > temp)
                    {
                        temp = j;
                    }

                    if (arr[j] < arr[i])
                    {
                        
                    }
                }
            }
            return new int[] { };
        }
    }
}