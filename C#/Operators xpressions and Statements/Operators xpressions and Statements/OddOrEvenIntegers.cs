using System;

    class OddOrEvenIntegers
{
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int result = n % 2;

            if (result == 0)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }