using System;
using System.Linq;

class PrintAReceipt
{
    static void Main()
    {
        decimal[] nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

        Console.WriteLine("/----------------------\\");
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine("| {0,20:f2} |", nums[i]);
        }
        Console.WriteLine("|----------------------|");
        Console.WriteLine("| Total: {0,13:f2} |", nums.Sum());
        Console.Write("\\----------------------/");
    }
}