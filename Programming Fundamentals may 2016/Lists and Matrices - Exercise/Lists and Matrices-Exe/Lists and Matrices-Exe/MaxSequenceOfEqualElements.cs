using System;
using System.Collections.Generic;
using System.Linq;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        List<int> listOfInt = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> sequences = new List<int>();
        List<int> longestSeqEqElements = new List<int>() { 1 };


        for (int i = 1; i < listOfInt.Count; i++)
        {
            if (listOfInt[i] == listOfInt[i - 1])
            {
                if (sequences.Count == 0)
                {
                    sequences.Add(listOfInt[i - 1]);
                    sequences.Add(listOfInt[i]);
                }
                else
                {
                    sequences.Add(listOfInt[i]);
                }

                if (sequences.Count > longestSeqEqElements.Count)
                {
                    longestSeqEqElements.Clear();
                    for (int j = 0; j < sequences.Count; j++)
                    {
                        longestSeqEqElements.Add(sequences[j]);
                    }
                }
            }
            else
            {
                sequences.Clear();
            }
        }
        Console.WriteLine(string.Join(" ", longestSeqEqElements));
    }
}