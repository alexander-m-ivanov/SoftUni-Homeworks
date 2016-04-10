using System;
class Print_the_ASCII_Table
{
    static void Main()
    {
        for (int symbol = 0; symbol < 256; symbol++)
        {
            Console.Write((char)symbol);
        }
    }
}