﻿using System;
class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int r = 0;
        if (n % 2 == 0)
        {
            r = n / 2;
        }
        else
        {
            r = (n + 1) / 2;
        }

        string framework = new string('*', n * 2);
        const string frameworkOne = "*";
        string space = new string(' ', n);
        string glass = new string('/', (n * 2) - 2);
        string handle = new string('|', n);
        for (int i = 1; i <= n; i++)
        {
            if (i == 1)
            {
                Console.Write(framework);
                Console.Write(space);
                Console.Write(framework);
                Console.WriteLine();
            }
            else if (i == r)
            {
                Console.Write(frameworkOne);
                Console.Write(glass);
                Console.Write(frameworkOne);
                Console.Write(handle);
                Console.Write(frameworkOne);
                Console.Write(glass);
                Console.Write(frameworkOne);
                Console.WriteLine();
            }
            else if (i == n)
            {
                Console.Write(framework);
                Console.Write(space);
                Console.Write(framework);
                Console.WriteLine();
            }
            else
            {
                Console.Write(frameworkOne);
                Console.Write(glass);
                Console.Write(frameworkOne);
                Console.Write(space);
                Console.Write(frameworkOne);
                Console.Write(glass);
                Console.Write(frameworkOne);
                Console.WriteLine();
            }
        }
    }
}