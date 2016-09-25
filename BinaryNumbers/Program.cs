using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string binary = Convert.ToString(n, 2);
        int consecutiveOnes = 0;
        int maxCount = 0;
        for(int i=0;i<binary.Length;i++)
        {
            if (binary.Substring(i,1) == "1")
            {
                consecutiveOnes += 1;
                if (consecutiveOnes > maxCount)
                    maxCount = consecutiveOnes;
            }
            else
            {
                consecutiveOnes = 0;
            }
        }
        Console.WriteLine(maxCount);
    }
}
