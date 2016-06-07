using System;
using System.Collections.Generic;
using System.Linq;

class SumAdjacentEqualNumbers
{
    static void Main()
    {
        List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        int counter = 1;

        while (counter > 0)
        {
            counter = 0;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers.Insert(i, numbers[i] + numbers[i + 1]);
                    numbers.RemoveAt(i + 1);
                    numbers.RemoveAt(i + 1);
                    counter += 1;
                    break;
                }
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}