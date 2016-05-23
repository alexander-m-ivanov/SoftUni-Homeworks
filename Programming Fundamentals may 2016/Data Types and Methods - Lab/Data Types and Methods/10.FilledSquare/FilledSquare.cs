using System;

namespace _10.FilledSquare
{
    class FilledSquare
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeaderAndBottomRow(n);
            PrintMiddleRow(n);
        }

        static void PrintHeaderAndBottomRow(int n)
        {
            string line = new string('-', n * 2);
            Console.Write(line);
        }

        static void PrintMiddleRow(int n)
        {
            Console.WriteLine();
            char startEndChar = '-';
            string filling = @"\/";

            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write(startEndChar);

                for (int j = 0; j <= n - 2; j++)
                {
                    Console.Write(filling);
                }
                Console.WriteLine(startEndChar);
            }
            PrintHeaderAndBottomRow(n);
        }
    }
}