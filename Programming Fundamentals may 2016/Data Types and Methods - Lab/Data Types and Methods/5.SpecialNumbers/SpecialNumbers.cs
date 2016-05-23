using System;

namespace _5.SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int digit1 = i % 10;
                int digit2 = i / 10;
                bool isSumOfDigitsEqual5 = digit1 + digit2 == 5;
                bool isSumOfDigitsEqual7 = digit1 + digit2 == 7;
                bool isSumOfDigitsEqual11 = digit1 + digit2 == 11;
                bool isSumOfDigitsSpecial = isSumOfDigitsEqual5 || isSumOfDigitsEqual7 || isSumOfDigitsEqual11;

                if (isSumOfDigitsSpecial)
                {
                    Console.WriteLine("{0} --> True", i);
                }
                else
                {
                    Console.WriteLine("{0} --> False", i);
                }
            }
        }
    }
}
