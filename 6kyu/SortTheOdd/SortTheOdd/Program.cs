using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices.ComTypes;

namespace SortTheOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort the odd numbers in ascending order
            //Leave the even numbers at their original positions
            //[7, 1, 3] => [1, 3, 7]
            //[5, 8, 6, 3, 4] => [3, 8, 6, 5, 4]
            //[9, 8, 7, 6, 5, 4, 3, 2, 1, 0]  =>  [1, 8, 3, 6, 5, 4, 7, 2, 9, 0]
            int[] array = new int[]
            {
                9, 8, 7, 6, 5, 4, 3, 2, 1, 0
            };

            int[] sortedArray = SortTheOdd(array);
            
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
        }

        static int[] SortTheOdd(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    continue;
                }

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] % 2 != 0)
                    {
                        if (array[i] > array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }

            return array;
        }
    }
}