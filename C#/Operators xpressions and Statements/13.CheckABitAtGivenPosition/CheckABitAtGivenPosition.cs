using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int positionShiftedNumber = number >> position;
        int bit = positionShiftedNumber & 1;

        bool isBitatP1 = bit == 1;

        Console.WriteLine(isBitatP1);
    }
}