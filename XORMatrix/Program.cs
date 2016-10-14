using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

class Solution
{
    static void Main(String[] args)
    {
        string[] rowsAndColumns = Console.ReadLine().Split(' ');
        int columns = Convert.ToInt32(rowsAndColumns[0]);
        long rows = Convert.ToInt64(rowsAndColumns[1]);


        string[] firstRowText = Console.ReadLine().Split(' ');
        long[] currentRow = Array.ConvertAll(firstRowText, Int64.Parse);


        if (rows > 1)
        {
            BruteForceMethod(columns, rows, currentRow);            
            //ShortMethod(columns, rows, currentRow);
        }
        else
        {
            PrintArray(currentRow);
        }

        Console.ReadLine();
    }

    private static void BruteForceMethod(int columns, long rows, long[] currentRow)
    {
        long[] transformedRow = new long[columns];

        for (int i = 1; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (j < columns - 1)
                    transformedRow[j] = currentRow[j] ^ currentRow[j + 1];
                else
                    transformedRow[j] = currentRow[j] ^ currentRow[0];
            }
            currentRow = transformedRow;
            transformedRow = new long[columns];
            PrintArray(currentRow,true);
        }
        //PrintArray(currentRow);
    }

    private static void ShortMethod(int columns, long rows, long[] currentRow)
    {
        long[] transformedRow = new long[columns];

        long numberOfTransformations = (rows - 1)%columns;
        for (int i = 0; i < numberOfTransformations; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (j < columns - 1)
                    transformedRow[j] = currentRow[j] ^ currentRow[j + 1];
                else
                    transformedRow[j] = currentRow[j] ^ currentRow[0];
            }
            currentRow = transformedRow;
            transformedRow = new long[columns];
            PrintArray(currentRow);
        }

        List<long> valueList = currentRow.ToList();
        int numberOfShifts = (int) rows/columns;
        for (int i = 0; i < numberOfShifts; i++)
        {
            long value = valueList[columns - 1];
            valueList.Insert(0, value);
            valueList.RemoveAt(columns);
        }

        foreach (var VARIABLE in valueList)
        {
            Console.Write(VARIABLE + " ");
        }
    }

    private static void PrintArray(long[] array, bool printBinary=false)
    {
        
        foreach (int i in array)
            if (printBinary)
                Console.Write(Convert.ToString(i, 2) + " ","00000000");
            else
                Console.Write(i + " ");
        Console.Write("\n");
    }
}