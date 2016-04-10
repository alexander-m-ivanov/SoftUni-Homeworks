using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());

        for (uint i = 1; i <= n; i++)
        {
            bool isItDivisibleBy3 = i % 3 != 0;
            bool isItDivisibleBy7 = i % 7 != 0;

            if (isItDivisibleBy3 && isItDivisibleBy7)
            {
                Console.Write("{0} ", i);
            }
            else
            {
                continue;
            }
        }
    }
}