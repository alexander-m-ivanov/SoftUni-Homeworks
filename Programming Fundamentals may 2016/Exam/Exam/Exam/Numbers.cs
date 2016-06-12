using System;
using System.Linq;

class Numbers
{
    static void Main()
    {
        double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        double average = numbers.Average();

        double[] aboveAverage = numbers.Where(x => x > average).ToArray();
        double[] orderByDescending = aboveAverage.OrderByDescending(n => n).ToArray();
        double[] aboveAverageTake5 = orderByDescending.Take(5).ToArray();

        if (aboveAverageTake5.Length == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine(string.Join(" ", aboveAverageTake5));
        }
    }
}