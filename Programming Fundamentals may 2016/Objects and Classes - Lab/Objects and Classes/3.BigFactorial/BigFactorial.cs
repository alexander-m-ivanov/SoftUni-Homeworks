using System;
using System.Numerics;

class BigFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger factoralResult = 1;
        for (int i = 1; i <= n; i++)
        {
            factoralResult *= i;
        }

        Console.WriteLine(factoralResult);
    }
}