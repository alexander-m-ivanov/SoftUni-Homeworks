using System;
using System.Linq;

class FoldАndSum
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int k = array.Length / 4;

        int[] firstLeft = array.Take(k).Reverse().ToArray();
        int[] lastRight = array.Reverse().Take(k).ToArray();

        int[] firstRow = firstLeft.Concat(lastRight).ToArray();
        int[] secondRow = array.Skip(k).Take(2*k).ToArray();

        int[] sumArray = firstRow.Select((x, index) => x + secondRow[index]).ToArray();

        Console.WriteLine(string.Join(" ", sumArray));
    }
}