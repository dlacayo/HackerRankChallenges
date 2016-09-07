using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int size = Convert.ToInt32(Console.ReadLine());

        PrintStaircase(size);
    }

    private static void PrintStaircase(int size)
    {
        for(int i=0;i<size;i++)
            PrintLevel(size-(1+i), 1+i);
    }

    private static void PrintLevel(int numberOfSpaces, int numberOfSymbols)
    {
        for(int i=0;i<numberOfSpaces;i++)
            Console.Write(" ");
        for (int i = 0; i < numberOfSymbols; i++)
            Console.Write("#");
        Console.Write("\n");

    }
}
