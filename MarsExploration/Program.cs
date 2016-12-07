using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int letterCount = 0;
        string S = Console.ReadLine();
        for (int i = 0; i < S.Length; i += 3)
        {
            if (S[i] != 'S') letterCount++;
            if (S[i+1] != 'O') letterCount++;
            if (S[i+2] != 'S') letterCount++;
        }

        Console.WriteLine(letterCount);
    }
}
