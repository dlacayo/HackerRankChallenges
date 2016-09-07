using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int size = Convert.ToInt32(Console.ReadLine());
        int[][] squareMatrix = new int[size][];
        for (int row = 0; row < size; row++)
        {
            string[] columnValues = Console.ReadLine().Split(' ');
            squareMatrix[row] = Array.ConvertAll(columnValues, Int32.Parse);
        }

        int diagonalDifference = CalculateDiagonalDifference(squareMatrix);
        Console.WriteLine(diagonalDifference);
    }

    private static int CalculateDiagonalDifference(int[][] squareMatrix)
    {
        int size = squareMatrix[0].Length;

        int primaryDiagonalSum = 0;
        int secondaryDiagonalSum = 0;

        for (int i = 0; i < size; i++)
        {
            primaryDiagonalSum += squareMatrix[i][i];
            int j = size - (1 + i);
            secondaryDiagonalSum += squareMatrix[i][j];
        }

        return Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
    }
}