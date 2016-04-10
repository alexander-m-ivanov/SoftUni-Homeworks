using System;

class BitwiseExtractBit
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine()); ;
        int positionShiftedNumber = (int)number >> 3;
        int bit = positionShiftedNumber & 1;

        string binary = Convert.ToString(number, 2).PadLeft(8, '0');
        string binary1 = Convert.ToString(positionShiftedNumber, 2).PadLeft(8, '0');
        string binary2 = Convert.ToString(1, 2).PadLeft(8, '0');
        string binary3 = Convert.ToString(bit, 2).PadLeft(8, '0');

        Console.WriteLine(bit);
        Console.WriteLine();
        Console.WriteLine(binary);
        Console.WriteLine(binary1);
        Console.WriteLine(binary2);
        Console.WriteLine(binary3);

    }
}