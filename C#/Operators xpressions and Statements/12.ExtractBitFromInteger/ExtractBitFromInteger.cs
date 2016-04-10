using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int positionShiftedNumber = number >> position;
        int bit = positionShiftedNumber & 1;

        Console.WriteLine(bit);
    }
}