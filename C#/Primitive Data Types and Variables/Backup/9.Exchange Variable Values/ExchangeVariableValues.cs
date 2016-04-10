using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c = b;
        Console.WriteLine(
            new string('-', 10) +
            "BEFORE CHANGE" +
            new string('-', 10) +
            "\n");
        Console.WriteLine("a = {0}\nb = {1}\n", a, b);

        Console.WriteLine(
            new string('-', 10) +
            "AFTER CHANGE" +
            new string('-', 11) +
            "\n");
        b = a;
        a = c;
        Console.WriteLine("a = {0}\nb = {1}\n", a, b);
        Console.WriteLine(new string('-', 33) + "\n");
    }
}