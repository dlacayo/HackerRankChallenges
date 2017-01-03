using System;

class Program
    {
        static void Main(string[] args)
        {

            int days = Convert.ToInt32(Console.ReadLine());

            int peopleSum = 0;
            int peopleForNextDay = 5;
            for (int i = 1; i <= days; i++)
            {
                int likesToday = peopleForNextDay / 2;
                peopleSum += likesToday;
                peopleForNextDay = likesToday * 3;
            }

            Console.WriteLine(peopleSum);
        }
    }
