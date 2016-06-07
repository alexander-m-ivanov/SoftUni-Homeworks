using System;
using System.Collections.Generic;
using System.Linq;

class AppendLists
{
    static void Main()
    {
        List<string> lists = Console.ReadLine().Split('|').Reverse().ToList();
        List<string> result = new List<string>();

        for (int i = 0; i <= lists.Count - 1; i++)
        {
            string[] list = lists[i].Split(' ');
            foreach (string item in list)
                result.Add(item);
        }
        result.RemoveAll(x => x == "");
        Console.WriteLine(string.Join(" ", result));
    }
}