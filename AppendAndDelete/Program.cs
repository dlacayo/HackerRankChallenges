using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        string t = Console.ReadLine();
        int k = Convert.ToInt32(Console.ReadLine());
        /**/

        /**/
        int minLength = Math.Min(s.Length, t.Length);
        int equalCharCount = 0;
        for (int i = 0; i < minLength; i++)
        {
            if (s[i] == t[i])
                equalCharCount++;
            else
                break;
        }

        int lettersToSubtract = s.Length - equalCharCount;
        int lettersToAdd = t.Length - equalCharCount;
        if (k == lettersToSubtract + lettersToAdd)
            Console.WriteLine("Yes");
        else
        {
            if (k < lettersToSubtract + lettersToAdd)
                Console.WriteLine("No");
            else
            {
                Console.Write("Yes");
                //WriteResult(k);
            }
        }
    }

    private static void WriteResult(int k)
    {
        if (k >= 0)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}
