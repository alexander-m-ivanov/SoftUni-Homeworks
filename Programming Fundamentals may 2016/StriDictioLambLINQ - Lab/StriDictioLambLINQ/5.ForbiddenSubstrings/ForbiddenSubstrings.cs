using System;

class ForbiddenSubstrings
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] forbiddenWords = Console.ReadLine().Split(' ');

        //string text = "Learn how to earn money or read the HOWto e - learning.";
        //string[] forbiddenWords = { "beer", "how", "programming", "PHP", "MySQL", "earn", "bitcoins" };

        foreach (var w in forbiddenWords)
        {
            string stars = new string('*', w.Length);
            text = text.Replace(w, stars);
        }

        Console.WriteLine(text);
    }
}