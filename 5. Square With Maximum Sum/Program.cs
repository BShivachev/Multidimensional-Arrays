using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            //int rows=input[0];
            //int cols=input[1];
            (int rows, int cols) = (input[0], input[1]);            
            int[,] matrix = new int[rows, cols];
            int maxSum = int.MinValue;
            int[,] maxSumSquare = new int[2, 2];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    int currentSum=
                        matrix[row,col]
                        +matrix[row,col+1]
                        +matrix[row+1,col]
                        +matrix[row+1,col+1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxSumSquare = new int[,] {
                            {matrix[row,col],matrix[row,col+1]},
                            {matrix[row+1,col],matrix[row+1,col+1]}
                        };
                    }
                }
            }
            for (int i = 0; i < maxSumSquare.GetLength(0); i++)
            {
                for (int j = 0; j < maxSumSquare.GetLength(1); j++)
                {
                    Console.Write($"{maxSumSquare[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum); for (int i = 0; i < maxSumSquare.GetLength(0); i++)
            {
                for (int j = 0; j < maxSumSquare.GetLength(1); j++)
                {
                    Console.Write($"{maxSumSquare[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}
