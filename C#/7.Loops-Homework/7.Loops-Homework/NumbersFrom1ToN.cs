using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());

        for (uint i = 1; i <= n; i++)
        {
            Console.Write("{0} ", i);
        }
    }
}