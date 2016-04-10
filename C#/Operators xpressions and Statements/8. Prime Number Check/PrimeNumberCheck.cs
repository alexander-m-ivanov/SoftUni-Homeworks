using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int remainderOf2 = n % 2;
        int remainderOf3 = n % 3;
        int remainderOf5 = n % 5;
        bool isPrime = (remainderOf2 != 0) && (remainderOf3 != 0) && (remainderOf5 != 0) && (n != 1);

        if (isPrime || (n == 2) || (n == 3) || (n == 5))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
