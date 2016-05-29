using System;

class ReverseAnArrayOfIntegers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] nums = new string[n];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = Console.ReadLine();
        }

        for (int j = nums.Length - 1; j > -1; j--)
        {
            if (j != 0)
            {
                Console.Write(nums[j] + " ");
            }
            else
            {
                Console.Write(nums[j]);
            }
        }
    }
}