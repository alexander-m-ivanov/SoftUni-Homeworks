using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = n; i > 1; i--)
        {
            for (int j = i - 1; j > 1; j--)
            {
                if (i % j == 0)
                {
                    break;
                }
                else if (j == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}