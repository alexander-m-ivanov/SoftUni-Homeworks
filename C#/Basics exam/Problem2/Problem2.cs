using System;

class Problem2
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        char a = 'a';
        char b = 'b';
        char c = 'c';
        char d = 'd';
        uint counterA = 0;
        uint counterB = 0;
        uint counterC = 0;
        uint counterD = 0;
        char[] answers;
        answers = new char[n];

        for (uint i = 0; i < n; i++)
        {
            uint nextInput = uint.Parse(Console.ReadLine());

            uint remainder = nextInput % 4;


            if (remainder == 0)
            {
               answers[i] = a;
                counterA += 1;
            }
            else if (remainder == 1)
            {
                answers[i] = b;
                counterB += 1;
            }
            else if (remainder == 2)
            {
                answers[i] = c;
                counterC += 1;
            }
            else if (remainder == 3)
            {
                answers[i] = d;
                counterD += 1;
            }
        }

        for (uint e = 0; e < answers.Length; e++)
        {
            Console.Write(answers[e]);
            if (e == answers.Length - 1)
            {
                Console.WriteLine();
                break;
            }
            Console.Write(" ");
        }

        Console.WriteLine("Answer A: {0}", counterA);
        Console.WriteLine("Answer B: {0}", counterB);
        Console.WriteLine("Answer C: {0}", counterC);
        Console.WriteLine("Answer D: {0}", counterD);
    }
}