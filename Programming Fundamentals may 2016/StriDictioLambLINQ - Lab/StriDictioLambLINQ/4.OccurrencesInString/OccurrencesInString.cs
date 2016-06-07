using System;
using System.Collections.Generic;
using System.Linq;

class OccurrencesInString
{
    static void Main()
    {
        string text = Console.ReadLine().ToLower();
        string substringForSearch = Console.ReadLine().ToLower();

        int startPosition = 0;
        int counter = 0;

        while (true)
        {
            int position = text.IndexOf(substringForSearch, startPosition);

            if (position == -1)
            {
                break;
            }
            counter ++;
            startPosition = position + 1;
        }

        Console.WriteLine(counter);
    }
}