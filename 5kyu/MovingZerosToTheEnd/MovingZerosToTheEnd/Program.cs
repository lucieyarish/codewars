using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingZerosToTheEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take an array and move all zeros to the end
            //Preserve the order of the other elements
            int[] myInts = new[]
            {
                1, 2, 0, 1, 0, 1, 0, 3, 0, 1
            }; // Expected result: {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}

            int[] transformedArray = MoveZeros(myInts);

            foreach (var item in transformedArray)
            {
                Console.Write(item + ", ");
            }
        }

        static int[] MoveZeros(int[] array)
        {
            var numsNoZeros = new List<int>();
            int arrayLength = array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    numsNoZeros.Add(array[i]);
                }
            }

            int zerosMissing = arrayLength - numsNoZeros.Count;

            for (int i = 0; i < zerosMissing; i++)
            {
                numsNoZeros.Add(0);
            }

            return numsNoZeros.ToArray();
        }

        //Linq solution
        // static int[] MoveZeros(int[] array)
        // {
        //     return array.OrderBy(n => n == 0).ToArray();
        // }
    }
}