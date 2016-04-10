using System;

class BitsExchange
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position3 = 3;
        int position4 = 4;
        int position5 = 5;
        int position24 = 24;
        int position25 = 25;
        int position26 = 26;

        int positionShitedNumber3 = number >> position3;
        int bit3 = positionShitedNumber3 & 1;

        int positionShitedNumber4 = number >> position4;
        int bit4 = positionShitedNumber4 & 1;

        int positionShitedNumber5 = number >> position5;
        int bit5 = positionShitedNumber5 & 1;

        int positionShitedNumber24 = number >> position24;
        int bit24 = positionShitedNumber24 & 1;

        int positionShitedNumber25 = number >> position25;
        int bit25 = positionShitedNumber25 & 1;

        int positionShitedNumber26 = number >> position26;
        int bit26 = positionShitedNumber26 & 1;

        string binary3 = Convert.ToString(bit3, 2);
        string binary4 = Convert.ToString(bit4, 2);
        string binary5 = Convert.ToString(bit5, 2);

        if (binary3 + binary4 + binary5 == "010")
        {
            int mask = 1 << position24;
            int result = number | mask;
        }
        else
        {
            int mask = ~(1 << position24);
            int result = number & mask;
        }

        if (bit4 == 1)
        {
            int mask = 1 << position25;
            int result = number | mask;
        }
        else
        {
            int mask = ~(1 << position24);
            int result = number & mask;
        }

        if (bit5 == 1)
        {
            int mask = 1 << position26;
            int result = number | mask;
        }
        else
        {
            int mask = ~(1 << position26);
            int result = number & mask;
        }

        if (bit24 == 1)
        {
            int mask = 1 << position3;
            int result = number | mask;
        }
        else
        {
            int mask = ~(1 << position3);
            int result = number & mask;
        }

        if (bit25 == 1)
        {
            int mask = 1 << position4;
            int result = number | mask;
        }
        else
        {
            int mask = ~(1 << position4);
            int result = number & mask;
        }

        if (bit26 == 1)
        {
            int mask = 1 << position5;
            int result = number | mask;
        }
        else
        {
            int mask = ~(1 << position5);
            int result = number & mask;
        }

        Console.WriteLine(bit3);
        Console.WriteLine(number);
        Console.WriteLine(binary3 + binary4 + binary5);

    }
}