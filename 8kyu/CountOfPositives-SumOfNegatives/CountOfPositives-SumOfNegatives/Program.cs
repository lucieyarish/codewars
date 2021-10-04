using System;

namespace CountOfPositives_SumOfNegatives
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            CountOfPositivesSumOfNegatives(myArr);
        }

        public static int[] CountOfPositivesSumOfNegatives(int[] myArr)
        {
            if (myArr.Length == 0 || myArr == null)
            {
                return new int[0];
            }
            else
            {
                int count = 0;
                int sum = 0;
                for (int i = 0; i <myArr.Length; i++)
                {
                    if (myArr[i] > 0)
                    {
                        count++;
                    }
                    else if (myArr[i] < 0)
                    {
                        sum += myArr[i];
                    }
                }
                int[] output = { count, sum};
                return output;
            }
        }
    }
}