﻿using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfSquareMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeOfSquareMatrix, sizeOfSquareMatrix];
            int sumOfDiagonal = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                sumOfDiagonal += matrix[i, i];
            }
            Console.WriteLine(sumOfDiagonal);
        }
    }
}
