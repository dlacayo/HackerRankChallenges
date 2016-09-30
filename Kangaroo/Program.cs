using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string[] tokens_x1 = Console.ReadLine().Split(' ');
        int x1 = Convert.ToInt32(tokens_x1[0]);
        int v1 = Convert.ToInt32(tokens_x1[1]);
        int x2 = Convert.ToInt32(tokens_x1[2]);
        int v2 = Convert.ToInt32(tokens_x1[3]);

        int startingDifference = x1 > x2 ? x1 - x2 : x2 - x1; // how many meters ahead is the other guy
        int velocityDifference = x1 > x2 ? v1 - v2 : v2 - v1; // is the other guy faster or slower? = 0 (same), > 0 faster, < 0 slower

        if(startingDifference == 0 && velocityDifference == 0)// catch up immediately
            Console.WriteLine("YES");

        if(startingDifference == 0 && velocityDifference > 0)// never will catch up, the other guy is faster
            Console.WriteLine("NO");

        if(velocityDifference >= 0) // I'm behind and the other guy is at least as fast as I am
            Console.WriteLine("NO");

        if (velocityDifference < 0) // this is my only shot. I'm behind but I'm faster
            if(startingDifference % (-1 * velocityDifference) == 0) // I will catch up to him
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO"); // I will pass him

    }
}
