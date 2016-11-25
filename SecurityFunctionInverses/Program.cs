using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

        for (int i = 1; i <= numbers.Length; i++)
            for (int j = 0; j < numbers.Length; j++)
                if (numbers[j] == i)
                    Console.WriteLine(j+1);

    }
}