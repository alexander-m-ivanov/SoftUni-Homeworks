using System;
using System.Collections.Generic;
using System.Linq;

class SquareNumbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> sqrtNumbers = new List<int>();


        for (int i = 0; i < numbers.Count; i++)
        {
            double sqrtNum = Math.Sqrt(numbers[i]);

            if (sqrtNum == (int)sqrtNum)
            {
                sqrtNumbers.Add((int)numbers[i]);
            }
        }

        sqrtNumbers.Sort((a, b) => b.CompareTo(a));

        Console.WriteLine(string.Join(" ", sqrtNumbers));
    }
}