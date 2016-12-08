using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int numberOfCLouds = Convert.ToInt32(Console.ReadLine());
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] clouds = Array.ConvertAll(c_temp, Int32.Parse);

        int numberOfJumps = 0;
        int currentCloud = 0;
        while (WeStillNeedToJump(currentCloud, numberOfCLouds))
        {
            if (WeCanTryToJumpTwoClouds(currentCloud, numberOfCLouds))
            {
                if (WeCanJumpTwoClouds(clouds, currentCloud))
                {
                    numberOfJumps++;
                    currentCloud += 2;
                }
                else
                {
                    numberOfJumps++;
                    currentCloud++;
                }
            }
            else
            {
                numberOfJumps++;
                currentCloud++;
            }
        }

        Console.WriteLine(numberOfJumps);
    }

    private static bool WeCanJumpTwoClouds(int[] clouds, int currentCloud)
    {
        return clouds[currentCloud + 2] != 1;
    }

    private static bool WeCanTryToJumpTwoClouds(int currentCloud, int numberOfCLouds)
    {
        return currentCloud + 2 < numberOfCLouds;
    }

    private static bool WeStillNeedToJump(int currentCloud, int numberOfCLouds)
    {
        return currentCloud < numberOfCLouds - 1;
    }
}
