using System;
using System.Linq;

class FoldАndSum
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int foldLength = arr.Length / 4;

        int[] firstFoldedRow = FoldingFirstRow(arr, foldLength);
        int[] secondFoldedRow = FoldingSecondRow(arr, foldLength);
        int[] output = new int[arr.Length / 2];

        for (int i = 0; i < output.Length; i++)
        {
            output[i] = firstFoldedRow[i] + secondFoldedRow[i];

            if (i == output.Length - 1)
            {
                Console.Write(output[i]);
            }
            else
            {
                Console.Write(output[i] + " ");
            }

        }
    }

    public static int[] FoldingFirstRow(int[] arr, int foldLength)
    {
        int[] firstFoldedRow = new int[arr.Length / 2];

        for (int i = 0; i < foldLength; i++)
        {
            firstFoldedRow[i] = arr[foldLength - 1 - i];
        }

        for (int j = 0; j < foldLength; j++)
        {
            firstFoldedRow[j + foldLength] = arr[arr.Length - 1 - j];
        }
        return firstFoldedRow;
    }

    public static int[] FoldingSecondRow(int[] arr, int foldLength)
    {
        int[] secondFoldedRow = new int[arr.Length / 2];

        for (int i = 0; i < secondFoldedRow.Length; i++)
        {
            secondFoldedRow[i] = arr[i + foldLength];
        }
        return secondFoldedRow;
    }
}