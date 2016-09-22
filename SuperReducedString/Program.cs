using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        string s = Console.ReadLine();

        for (int i = 1; i < s.Length; i++)
            if (s[i] == s[i - 1])
            {
                s = s.Remove(i - 1, 2);
                i = 0;
            }

        Console.WriteLine(s.Length == 0 ? "Empty String" : s);
    }
}