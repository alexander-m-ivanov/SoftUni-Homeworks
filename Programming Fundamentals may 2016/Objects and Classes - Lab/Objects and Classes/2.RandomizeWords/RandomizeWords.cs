using System;
using System.Linq;

class RandomizeWords
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(' ').ToArray();

        Random rnd = new Random();

        for (int i = 0; i < words.Length; i++)
        {
            int second = rnd.Next(0, words.Length);
            string old = words[i];
            words[i] = words[second];
            words[second] = old;
        }
        Console.WriteLine(string.Join("\r\n", words));
    }
}