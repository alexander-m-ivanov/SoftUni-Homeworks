using System;

namespace _6.TriplesOfLatinLetters
{
    class TriplesOfLatinLetters
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                char letter1 = (char)('a' + i);

                for (int j = 0; j < num; j++)
                {
                    char letter2 = (char)('a' + j);

                    for (int k = 0; k < num; k++)
                    {
                        char letter3 = (char)('a' + k);
                        Console.Write("{0}{1}{2}", letter1, letter2, letter3);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
