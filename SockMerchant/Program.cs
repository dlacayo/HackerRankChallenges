using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp, Int32.Parse);

        Array.Sort(c);

        int numberOfPairs = 0;
        for (int i = 0; i < n-1; i++)
        {
            if (c[i] == c[i + 1])
            {
                numberOfPairs++;
                i++;
            }
        }

        Console.WriteLine(numberOfPairs);
    }
}
