using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Difference
{
    private int[] elements;
    public int maximumDifference;

    public Difference(int[] elems)
    {
        this.elements = elems;
    }

    public void computeDifference()
    {
        int length = elements.Length;
        for (int i = 0; i < length; i++)
            for (int j = i + 1; j < length; j++)
            {
                int diff = Math.Abs(elements[i] - elements[j]);
                if (diff > maximumDifference)
                    maximumDifference = diff;
            }
    }
}

class Solution
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}