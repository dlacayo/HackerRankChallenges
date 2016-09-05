using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static string CompareScores(int[] firstScoreSet, int[] secondScoreSet)
    {
        if (firstScoreSet.Length != secondScoreSet.Length)
            return "";

        int firstScore = 0;
        int secondScore = 0;

        int arrayLength = firstScoreSet.Length;
        for (int i = 0; i < arrayLength; i++)
        {
            if (firstScoreSet[i] > secondScoreSet[i])
            {
                firstScore += 1;
            }
            else if (firstScoreSet[i] < secondScoreSet[i])
            {

                secondScore += 1;
            }
        }

        return string.Format($"{firstScore} {secondScore}");
    }

    static void Main(String[] args)
    {
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        int a0 = Convert.ToInt32(tokens_a0[0]);
        int a1 = Convert.ToInt32(tokens_a0[1]);
        int a2 = Convert.ToInt32(tokens_a0[2]);
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        int b0 = Convert.ToInt32(tokens_b0[0]);
        int b1 = Convert.ToInt32(tokens_b0[1]);
        int b2 = Convert.ToInt32(tokens_b0[2]);

        int[] firstSet = new int[] { a0, a1, a2 };
        int[] secondSet = new int[] { b0, b1, b2 };

        Console.WriteLine(CompareScores(firstSet, secondSet));

    }
}
