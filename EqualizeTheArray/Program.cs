using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] A_temp = Console.ReadLine().Split(' ');
        int[] numberArray = Array.ConvertAll(A_temp, Int32.Parse);

        Array.Sort(numberArray);

        int maxRepeats = 0;
        int currentNumber = numberArray[0];
        int currentNumberRepeats = 1;
        int index = 1;
        while (index < n)
        {
            if (numberArray[index] == currentNumber)
                currentNumberRepeats++;
            else
            {
                currentNumber = numberArray[index];
                currentNumberRepeats = 1;
            }

            if (currentNumberRepeats > maxRepeats)
                maxRepeats = currentNumberRepeats;
            index++;
        }
        Console.WriteLine(n - maxRepeats);
    }
}