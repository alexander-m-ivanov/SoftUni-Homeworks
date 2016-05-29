using System;
using System.Linq;

class CondenseArrayToNumber
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        while (arr.Length > 1)
        {
            int[] condensed = new int[arr.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < arr.Length - 1)
                {
                    condensed[i] = arr[i] + arr[i + 1];
                }
            }
            arr = condensed;
        }
        Console.WriteLine(arr[0]);
    }
}