using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        string[] itemInfo = Console.ReadLine().Split(' ');
        int numberOfItems = Convert.ToInt32(itemInfo[0]);
        int itemNotEaten = Convert.ToInt32(itemInfo[1]);
        string[] itemValues = Console.ReadLine().Split(' ');
        int[] values = Array.ConvertAll(itemValues, Int32.Parse);
        int amountCharged = Convert.ToInt32(Console.ReadLine());

        int amountToSplitWithAnna = 0;
        for (int i = 0; i < numberOfItems; i++)
            if (i != itemNotEaten)
                amountToSplitWithAnna += values[i];

        int whatAnnaHasToPay = amountToSplitWithAnna/2;

        Console.WriteLine(whatAnnaHasToPay == amountCharged ? "Bon Appetit":(amountCharged-whatAnnaHasToPay).ToString());

    }
}