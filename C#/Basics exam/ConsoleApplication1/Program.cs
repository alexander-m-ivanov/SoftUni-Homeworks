using System;

class Program
{
    static void Main()
    {
        string line = Console.ReadLine();
        int price = 0;

        char[] transactions = line.ToCharArray();

        for (int i = 0; i < transactions.Length; i++)
        {
            price += (int) transactions[i];
        }

        Console.WriteLine(price);
    }
}