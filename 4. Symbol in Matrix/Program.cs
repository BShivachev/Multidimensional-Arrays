using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfSquareMatrix = int.Parse(Console.ReadLine());
            char[,] matrix = new char[sizeOfSquareMatrix, sizeOfSquareMatrix];
            bool isOccurs = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] symbols = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = symbols[col];
                }
            }
            char symbolForCheck = char.Parse(Console.ReadLine());
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col].Equals(symbolForCheck))
                    {
                        isOccurs = true;
                        Console.WriteLine($"({row}, {col})");
                        break;
                    }
                }
                if (isOccurs)
                {
                    break;
                }
            }
            if (!isOccurs)
            {

                Console.WriteLine($"{symbolForCheck} does not occur in the matrix");
            }

        }
    }
}
