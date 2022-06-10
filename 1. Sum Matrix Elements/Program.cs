using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input =Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            //int rows=input[0];
            //int cols=input[1];
            (int rows,int cols)=(input[0],input[1]);
            int sumOfElements=0;
            int[,] matrix = new int[rows,cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements=Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = elements[col];
                }
            }
            foreach (var item in matrix)
            {
                sumOfElements += item;
            }
            Console.WriteLine($"{rows}\n{cols}\n{sumOfElements}");

        }
    }
}
