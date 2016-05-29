using System;
using System.Linq;

class ReverseAnArrayOfStrings
{
    static void Main()
    {
        string[] str = Console.ReadLine().Split(' ');

        for (int i = str.Length - 1; i >= 0; i--)
        {
            if (i != 0)
            {
                Console.Write(str[i] + " ");
            }
            else
            {
                Console.Write(str[i]);
            }
        }
    }
}