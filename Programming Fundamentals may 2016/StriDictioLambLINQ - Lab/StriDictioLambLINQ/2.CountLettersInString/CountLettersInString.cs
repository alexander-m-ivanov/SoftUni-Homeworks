using System;
using System.Collections.Generic;
using System.Linq;

class CountLettersInString
{
    static void Main()
    {
        string str = Console.ReadLine().ToLower();
        int[] countChar = new int[str.Max() + 1];

        for (int i = 0; i < str.Length; i++)
        {
            countChar[str[i]]++;
        }

        for (int j = 0; j < countChar.Length; j++)
        {
            if (countChar[j] > 0)
            {
                Console.WriteLine("{0} -> {1}", (char)j, countChar[j]);
            }
        }
    }
}