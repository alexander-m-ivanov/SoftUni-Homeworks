using System;

class QuotesInStrings
{
    static void Main()
    {
        string noQuote = "The \"use\" of quotations causes difficulties.";
        string Quote = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(noQuote + "\n" +Quote);
    }
}