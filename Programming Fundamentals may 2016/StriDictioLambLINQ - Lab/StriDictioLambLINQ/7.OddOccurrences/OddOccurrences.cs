using System;
using System.Collections.Generic;

class OddOccurrences
{
    static void Main()
    {
        string[] words = Console.ReadLine().ToLower().Split(' ');
        Dictionary<string, int> counts = new Dictionary<string, int>();

        foreach (var w in words)
        {
            if (counts.ContainsKey(w))
            {
                counts[w]++;
            }
            else
            {
                counts[w] = 1;
            }
        }

        List<string> list = new List<string>();
        foreach (var pair in counts)
        {
            if (pair.Value % 2 == 1)
            {
                list.Add(pair.Key);
            }
        }

        Console.WriteLine(string.Join(", ", list));
    }
}