using System;
using System.Linq;

class TripleSum
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ')
            .Select(int.Parse).ToArray();

        int countContainsSum = 0;

        for (int i = 0; i < nums.Length; i++)
            for (int j = i + 1; j < nums.Length; j++)
            {
                int a = nums[i];
                int b = nums[j];
                int sum = a + b;
                if (nums.Contains(sum))
                {
                    Console.WriteLine($"{a} + {b} == {sum}");
                    countContainsSum += 1;
                }
            }
        if (countContainsSum == 0)
        {
            Console.WriteLine("No");
        }
    }
}