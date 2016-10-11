using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Win32.SafeHandles;

class Solution
{

    static void Main(String[] args)
    {
        int Q = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < Q; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string b = Console.ReadLine();

            CheckForUnhappyLadybugs(n, b);
        }
    }

    private static void CheckForUnhappyLadybugs(int n, string s)
    {
        char[] separateLetters = s.ToCharArray();

        if (s.Contains("_"))
            Array.Sort(separateLetters);

        for (int i = 0; i < n; i++)
        {
            if (char.IsLetter(separateLetters[i]))
            {
                bool sameBefore = false;
                bool sameAfter = false;
                if (i > 0)
                    sameBefore = separateLetters[i] == separateLetters[i - 1];
                if (i < n - 1)
                    sameAfter = separateLetters[i] == separateLetters[i + 1];

                if (!sameBefore && !sameAfter)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
        }
        Console.WriteLine("YES");
    }
}
