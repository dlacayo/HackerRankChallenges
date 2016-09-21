using System;
using System.Collections.Generic;
using System.Text;

class Solution
{

    static void Main(String[] args)
    {
        string[] separatedParams = Console.ReadLine().Split(' ');
        int elementCount = Convert.ToInt32(separatedParams[0]);
        int rotationCount = Convert.ToInt32( separatedParams[1]);
        int necessaryRotations = rotationCount%elementCount;
        int queryCount = Convert.ToInt32(separatedParams[2]);

        List<int> elements = new List<int>(elementCount);
        string[] splitElements = Console.ReadLine().Split(' ');
        foreach (string s in splitElements)
            elements.Add(Convert.ToInt32(s));

        for (int i = 0; i < necessaryRotations; i++)
        {
            int element = elements[elementCount - 1];
            elements.Insert(0,element);
            elements.RemoveAt(elementCount);
        }


        StringBuilder answer = new StringBuilder();
        for (int i = 0; i < queryCount; i++)
        {
            int index = Convert.ToInt32(Console.ReadLine());
            answer.AppendLine(elements[index].ToString());
        }

        Console.WriteLine(answer.ToString());        
    }

   
}