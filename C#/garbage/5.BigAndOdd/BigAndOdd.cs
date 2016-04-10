using System;

class BigAndOdd
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool greater = n > 20;
        bool odd = (n % 2) == 1;
        bool result = greater && odd;
        Console.WriteLine(result);
    }
}
