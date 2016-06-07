using System;
using System.Collections.Generic;
using System.Linq;

class PrintStringLetters
{
    static void Main()
    {
        string str = Console.ReadLine();
        for (int i = 0; i < str.Length; i++)
        {
            Console.WriteLine("str[{0}] -> '{1}'", i, str[i]);
        }
    }
}