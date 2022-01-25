using System;

namespace IsSymmetricOrNot
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
                {1, 0, 1, 1},
                {0, 4, 2, 2},
                {1, 2, 3, 5},
                {1, 2, 5, 6}
            };

            int[,] matrix2 = new int[,]
            {
                {1, 3, 1, 1},
                {2, 4, 2, 2},
                {1, 2, 3, 5},
                {1, 2, 5, 6}
            };

            //Console.WriteLine(IsSymmetric(matrix)); //returns true
            //IsSymmetric(matrix2); returns false
            
            GetDiagonal();
        }

        public static void GetDiagonal()
        {
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 6; col++)
                {
                    if (row == col)
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                }
                Console.WriteLine();  
            }
        }
        
        public static bool IsSymmetric(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i + 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] != matrix[j,i])
                    {
                        return false;
                    }
                }   
            }

            return true;
        }
    }
}