using System;
using System.Linq;

class RotateAndSum
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int k = int.Parse(Console.ReadLine());
        int[] sum = new int[arr.Length];

        for (int i = 0; i < k; i++)
        {
            int[] rotatedArr = new int[arr.Length];

            for (int j = 0; j < arr.Length; j++)
            {
                int arrLastElement = arr[arr.Length - 1];
                if (j != 0)
                {
                    rotatedArr[j] = arr[j - 1];
                }
                else
                {
                    rotatedArr[j] = arrLastElement;
                }
            }
            arr = rotatedArr;

            for (int j = 0; j < sum.Length; j++)
            {
                sum[j] = sum[j] + rotatedArr[j];
            }
        }

        for (int j = 0; j < arr.Length; j++)
        {
            if (j != arr.Length - 1)
            {
                Console.Write(sum[j] + " ");
            }
            else
            {
                Console.Write(sum[j]);
            }
        }
    }
}