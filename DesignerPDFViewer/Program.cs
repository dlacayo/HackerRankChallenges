using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string[] h_temp = Console.ReadLine().Split(' ');
        int[] h = Array.ConvertAll(h_temp, Int32.Parse);
        string word = Console.ReadLine();

        int maxLetterHeight = 0;

        foreach (char c in word)
        {
            int currentLetterHeight = h[(int) c - 97];
            maxLetterHeight = currentLetterHeight > maxLetterHeight ? currentLetterHeight : maxLetterHeight;
        }

        Console.WriteLine(maxLetterHeight*word.Length);
    }
}
