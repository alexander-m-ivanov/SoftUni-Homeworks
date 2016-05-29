using System;
using System.Linq;

class RoundingNumbersAwayFromZero
{
    static void Main()
    {
        double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                double result = nums[i] + 0.5;
                Console.WriteLine("{0} => {1}", nums[i], (int)result);
            }
            else
            {
                double result = (nums[i] * -1) + 0.5;
                Console.WriteLine("{0} => {1}", nums[i], (int)result * -1);
            }
        }
    }
}